namespace ADPineapple
{
	partial class ConnectionDialog
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
			this.GBConnection = new System.Windows.Forms.GroupBox();
			this.RBConnectionLocal = new System.Windows.Forms.RadioButton();
			this.RBConnectionDomain = new System.Windows.Forms.RadioButton();
			this.txtBoxDomain = new System.Windows.Forms.TextBox();
			this.GBAuthentication = new System.Windows.Forms.GroupBox();
			this.RBCredentialsDifferent = new System.Windows.Forms.RadioButton();
			this.RBCredentialsCurrent = new System.Windows.Forms.RadioButton();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.GBConnection.SuspendLayout();
			this.GBAuthentication.SuspendLayout();
			this.SuspendLayout();
			// 
			// GBConnection
			// 
			this.GBConnection.Controls.Add(this.txtBoxDomain);
			this.GBConnection.Controls.Add(this.RBConnectionDomain);
			this.GBConnection.Controls.Add(this.RBConnectionLocal);
			this.GBConnection.Location = new System.Drawing.Point(12, 12);
			this.GBConnection.Name = "GBConnection";
			this.GBConnection.Size = new System.Drawing.Size(433, 80);
			this.GBConnection.TabIndex = 0;
			this.GBConnection.TabStop = false;
			this.GBConnection.Text = "Connection";
			// 
			// RBConnectionLocal
			// 
			this.RBConnectionLocal.AutoSize = true;
			this.RBConnectionLocal.Checked = true;
			this.RBConnectionLocal.Location = new System.Drawing.Point(6, 19);
			this.RBConnectionLocal.Name = "RBConnectionLocal";
			this.RBConnectionLocal.Size = new System.Drawing.Size(167, 17);
			this.RBConnectionLocal.TabIndex = 0;
			this.RBConnectionLocal.TabStop = true;
			this.RBConnectionLocal.Text = "Connect to the local computer";
			this.RBConnectionLocal.UseVisualStyleBackColor = true;
			this.RBConnectionLocal.CheckedChanged += new System.EventHandler(this.RBConnection_CheckedChanged);
			// 
			// RBConnectionDomain
			// 
			this.RBConnectionDomain.AutoSize = true;
			this.RBConnectionDomain.Location = new System.Drawing.Point(6, 42);
			this.RBConnectionDomain.Name = "RBConnectionDomain";
			this.RBConnectionDomain.Size = new System.Drawing.Size(126, 17);
			this.RBConnectionDomain.TabIndex = 1;
			this.RBConnectionDomain.Text = "Connect to a domain:";
			this.RBConnectionDomain.UseVisualStyleBackColor = true;
			this.RBConnectionDomain.CheckedChanged += new System.EventHandler(this.RBConnection_CheckedChanged);
			// 
			// txtBoxDomain
			// 
			this.txtBoxDomain.Enabled = false;
			this.txtBoxDomain.Location = new System.Drawing.Point(138, 41);
			this.txtBoxDomain.Name = "txtBoxDomain";
			this.txtBoxDomain.Size = new System.Drawing.Size(261, 20);
			this.txtBoxDomain.TabIndex = 2;
			// 
			// GBAuthentication
			// 
			this.GBAuthentication.Controls.Add(this.RBCredentialsDifferent);
			this.GBAuthentication.Controls.Add(this.RBCredentialsCurrent);
			this.GBAuthentication.Location = new System.Drawing.Point(12, 98);
			this.GBAuthentication.Name = "GBAuthentication";
			this.GBAuthentication.Size = new System.Drawing.Size(433, 80);
			this.GBAuthentication.TabIndex = 3;
			this.GBAuthentication.TabStop = false;
			this.GBAuthentication.Text = "Authentication";
			// 
			// RBCredentialsDifferent
			// 
			this.RBCredentialsDifferent.AutoSize = true;
			this.RBCredentialsDifferent.Location = new System.Drawing.Point(6, 42);
			this.RBCredentialsDifferent.Name = "RBCredentialsDifferent";
			this.RBCredentialsDifferent.Size = new System.Drawing.Size(333, 17);
			this.RBCredentialsDifferent.TabIndex = 1;
			this.RBCredentialsDifferent.Text = "Use a different user account (you will be prompted for credentials)";
			this.RBCredentialsDifferent.UseVisualStyleBackColor = true;
			// 
			// RBCredentialsCurrent
			// 
			this.RBCredentialsCurrent.AutoSize = true;
			this.RBCredentialsCurrent.Checked = true;
			this.RBCredentialsCurrent.Location = new System.Drawing.Point(6, 19);
			this.RBCredentialsCurrent.Name = "RBCredentialsCurrent";
			this.RBCredentialsCurrent.Size = new System.Drawing.Size(174, 17);
			this.RBCredentialsCurrent.TabIndex = 0;
			this.RBCredentialsCurrent.TabStop = true;
			this.RBCredentialsCurrent.Text = "Use the currently logged-in user";
			this.RBCredentialsCurrent.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(370, 193);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(289, 193);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// ConnectionDialog
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(457, 226);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.GBAuthentication);
			this.Controls.Add(this.GBConnection);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectionDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Connect to Active Directory...";
			this.GBConnection.ResumeLayout(false);
			this.GBConnection.PerformLayout();
			this.GBAuthentication.ResumeLayout(false);
			this.GBAuthentication.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GBConnection;
		private System.Windows.Forms.TextBox txtBoxDomain;
		private System.Windows.Forms.RadioButton RBConnectionDomain;
		private System.Windows.Forms.RadioButton RBConnectionLocal;
		private System.Windows.Forms.GroupBox GBAuthentication;
		private System.Windows.Forms.RadioButton RBCredentialsDifferent;
		private System.Windows.Forms.RadioButton RBCredentialsCurrent;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnConnect;
	}
}