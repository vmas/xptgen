using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace XptGen
{
	public partial class MainForm : Form
	{
		class Data
		{
			public string SDKPath;
			public string InputFile;
			public string OutputFile;
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnSdk_Click(object sender, EventArgs e)
		{
			using(var dlg = new FolderBrowserDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					txtSdk.Text = dlg.SelectedPath;
			}
		}

		private void btnIDL_Click(object sender, EventArgs e)
		{
			using (var dlg = new FolderBrowserDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					txtIDL.Text = dlg.SelectedPath;
			}
		}

		private void btnOut_Click(object sender, EventArgs e)
		{
			using (var dlg = new SaveFileDialog())
			{
				dlg.Filter = "XPT files (*.xpt)|*.xpt";
				if (dlg.ShowDialog() == DialogResult.OK)
					txtOut.Text = dlg.FileName;
			}
		}

		private void btnGen_Click(object sender, EventArgs e)
		{
			var data = new Data();
			//data.IDLPath = txtIDL.Text;
			data.SDKPath = txtSdk.Text;
			data.OutputFile = txtOut.Text;

			var includes = new List<string>();
			var sb = new StringBuilder();
			foreach(string filename in Directory.GetFiles(txtIDL.Text, "*idl", SearchOption.TopDirectoryOnly))
			{
				foreach(string line in File.ReadAllLines(filename, Encoding.UTF8))
				{
					if(line.StartsWith("#include"))
					{
						int start = line.IndexOf('"') + 1;
						int end = line.IndexOf('"', start);
						string name = "#include \"" + line.Substring(start, end - start) + "\"";
						if(!includes.Contains(name))
							includes.Add(name);
					}
					else
					{
						sb.AppendLine(line);
					}
				}
				sb.AppendLine().AppendLine();
			}
			sb.Insert(0, string.Join("\r\n", includes.ToArray()) + "\r\n\r\n");
			data.InputFile = Path.Combine(txtIDL.Text, Path.GetRandomFileName().Replace(".", "") + ".idl");
			File.WriteAllText(data.InputFile, sb.ToString());

			ThreadPool.QueueUserWorkItem(new WaitCallback(DoGenerate), data);
			panel.Enabled = false;
		}

		private void DoGenerate(object state)
		{
			var data = (Data)state;
			var psi = new ProcessStartInfo();
			psi.RedirectStandardOutput = true;
			psi.RedirectStandardInput = true;
			psi.RedirectStandardError = true;
			psi.UseShellExecute = false;

			psi.FileName = "cmd.exe";
			psi.Arguments = string.Format("/c \"\"{0}\" \"{1}\" -o \"{2}\" -I \"{3}\"\"",
				Path.Combine(data.SDKPath, Path.Combine("sdk", Path.Combine("bin", "typelib.py"))),
				data.InputFile,
				data.OutputFile,
				Path.Combine(data.SDKPath, "idl")
				);
			string log = string.Empty;
			Process process = null;
			try
			{
				process = Process.Start(psi);
				process.WaitForExit();
				
				log = process.StandardOutput.ReadToEnd();
				log = process.StandardError.ReadToEnd();
			}
			catch (Exception) { }
			finally
			{
				panel.Invoke(new Action(() => panel.Enabled = true));
				File.Delete(data.InputFile);
			}
		}
	}
}
