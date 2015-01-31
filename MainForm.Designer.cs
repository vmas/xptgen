namespace XptGen
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblSdk = new System.Windows.Forms.Label();
			this.txtSdk = new System.Windows.Forms.TextBox();
			this.lblIdl = new System.Windows.Forms.Label();
			this.txtIDL = new System.Windows.Forms.TextBox();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.lblOut = new System.Windows.Forms.Label();
			this.btnSdk = new System.Windows.Forms.Button();
			this.btnIDL = new System.Windows.Forms.Button();
			this.btnOut = new System.Windows.Forms.Button();
			this.btnGen = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSdk
			// 
			this.lblSdk.AutoSize = true;
			this.lblSdk.Location = new System.Drawing.Point(3, 4);
			this.lblSdk.Name = "lblSdk";
			this.lblSdk.Size = new System.Drawing.Size(91, 13);
			this.lblSdk.TabIndex = 1;
			this.lblSdk.Text = "XULRunner SDK:";
			// 
			// txtSdk
			// 
			this.txtSdk.Location = new System.Drawing.Point(3, 20);
			this.txtSdk.Name = "txtSdk";
			this.txtSdk.Size = new System.Drawing.Size(396, 20);
			this.txtSdk.TabIndex = 2;
			this.txtSdk.Text = "G:\\build\\xulfx\\PutXulRunnerFolderHere\\xulrunner-sdk";
			// 
			// lblIdl
			// 
			this.lblIdl.AutoSize = true;
			this.lblIdl.Location = new System.Drawing.Point(3, 43);
			this.lblIdl.Name = "lblIdl";
			this.lblIdl.Size = new System.Drawing.Size(64, 13);
			this.lblIdl.TabIndex = 3;
			this.lblIdl.Text = "Path to IDL:";
			// 
			// txtIDL
			// 
			this.txtIDL.Location = new System.Drawing.Point(3, 59);
			this.txtIDL.Name = "txtIDL";
			this.txtIDL.Size = new System.Drawing.Size(396, 20);
			this.txtIDL.TabIndex = 4;
			this.txtIDL.Text = "G:\\build\\xulfx\\XulFx\\XPI";
			// 
			// txtOut
			// 
			this.txtOut.Location = new System.Drawing.Point(3, 98);
			this.txtOut.Name = "txtOut";
			this.txtOut.ReadOnly = true;
			this.txtOut.Size = new System.Drawing.Size(396, 20);
			this.txtOut.TabIndex = 6;
			this.txtOut.Text = "G:\\Xulfx.xpt";
			// 
			// lblOut
			// 
			this.lblOut.AutoSize = true;
			this.lblOut.Location = new System.Drawing.Point(3, 82);
			this.lblOut.Name = "lblOut";
			this.lblOut.Size = new System.Drawing.Size(42, 13);
			this.lblOut.TabIndex = 5;
			this.lblOut.Text = "Output:";
			// 
			// btnSdk
			// 
			this.btnSdk.Location = new System.Drawing.Point(405, 18);
			this.btnSdk.Name = "btnSdk";
			this.btnSdk.Size = new System.Drawing.Size(30, 23);
			this.btnSdk.TabIndex = 7;
			this.btnSdk.Text = "...";
			this.btnSdk.UseVisualStyleBackColor = true;
			this.btnSdk.Click += new System.EventHandler(this.btnSdk_Click);
			// 
			// btnIDL
			// 
			this.btnIDL.Location = new System.Drawing.Point(405, 57);
			this.btnIDL.Name = "btnIDL";
			this.btnIDL.Size = new System.Drawing.Size(30, 23);
			this.btnIDL.TabIndex = 8;
			this.btnIDL.Text = "...";
			this.btnIDL.UseVisualStyleBackColor = true;
			this.btnIDL.Click += new System.EventHandler(this.btnIDL_Click);
			// 
			// btnOut
			// 
			this.btnOut.Location = new System.Drawing.Point(405, 96);
			this.btnOut.Name = "btnOut";
			this.btnOut.Size = new System.Drawing.Size(30, 23);
			this.btnOut.TabIndex = 9;
			this.btnOut.Text = "...";
			this.btnOut.UseVisualStyleBackColor = true;
			this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
			// 
			// btnGen
			// 
			this.btnGen.Location = new System.Drawing.Point(129, 124);
			this.btnGen.Name = "btnGen";
			this.btnGen.Size = new System.Drawing.Size(148, 23);
			this.btnGen.TabIndex = 10;
			this.btnGen.Text = "Generate an .xpt file";
			this.btnGen.UseVisualStyleBackColor = true;
			this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.txtSdk);
			this.panel.Controls.Add(this.btnGen);
			this.panel.Controls.Add(this.lblSdk);
			this.panel.Controls.Add(this.btnOut);
			this.panel.Controls.Add(this.lblIdl);
			this.panel.Controls.Add(this.btnIDL);
			this.panel.Controls.Add(this.txtIDL);
			this.panel.Controls.Add(this.btnSdk);
			this.panel.Controls.Add(this.lblOut);
			this.panel.Controls.Add(this.txtOut);
			this.panel.Location = new System.Drawing.Point(12, 12);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(438, 151);
			this.panel.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 169);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "XptGen";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblSdk;
		private System.Windows.Forms.TextBox txtSdk;
		private System.Windows.Forms.Label lblIdl;
		private System.Windows.Forms.TextBox txtIDL;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.Label lblOut;
		private System.Windows.Forms.Button btnSdk;
		private System.Windows.Forms.Button btnIDL;
		private System.Windows.Forms.Button btnOut;
		private System.Windows.Forms.Button btnGen;
		private System.Windows.Forms.Panel panel;

	}
}

