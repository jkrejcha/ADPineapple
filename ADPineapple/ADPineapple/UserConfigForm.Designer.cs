namespace ADPineapple
{
	partial class UserConfigForm
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
			this.components = new System.ComponentModel.Container();
			this.TCUserProperties = new System.Windows.Forms.TabControl();
			this.tpGeneral = new System.Windows.Forms.TabPage();
			this.tbWebpage = new System.Windows.Forms.TextBox();
			this.lblWebpage = new System.Windows.Forms.Label();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.tbPhoneNumber = new System.Windows.Forms.TextBox();
			this.userPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.tbOffice = new System.Windows.Forms.TextBox();
			this.lblOffice = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbDisplayName = new System.Windows.Forms.TextBox();
			this.lblDisplayName = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.tbMiddleInitial = new System.Windows.Forms.TextBox();
			this.lblMiddleInitial = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.tpAddress = new System.Windows.Forms.TabPage();
			this.tpAccount = new System.Windows.Forms.TabPage();
			this.gbAccountExpiry = new System.Windows.Forms.GroupBox();
			this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
			this.rbAtTheEndOf = new System.Windows.Forms.RadioButton();
			this.rbExpiresNever = new System.Windows.Forms.RadioButton();
			this.clbAccountOptions = new System.Windows.Forms.CheckedListBox();
			this.tpMemberOf = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.TCUserProperties.SuspendLayout();
			this.tpGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPrincipalBindingSource)).BeginInit();
			this.tpAccount.SuspendLayout();
			this.gbAccountExpiry.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TCUserProperties
			// 
			this.TCUserProperties.Controls.Add(this.tpGeneral);
			this.TCUserProperties.Controls.Add(this.tpAddress);
			this.TCUserProperties.Controls.Add(this.tpAccount);
			this.TCUserProperties.Controls.Add(this.tpMemberOf);
			this.TCUserProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TCUserProperties.Location = new System.Drawing.Point(0, 0);
			this.TCUserProperties.Name = "TCUserProperties";
			this.TCUserProperties.SelectedIndex = 0;
			this.TCUserProperties.Size = new System.Drawing.Size(439, 406);
			this.TCUserProperties.TabIndex = 0;
			// 
			// tpGeneral
			// 
			this.tpGeneral.Controls.Add(this.tbWebpage);
			this.tpGeneral.Controls.Add(this.lblWebpage);
			this.tpGeneral.Controls.Add(this.tbEmail);
			this.tpGeneral.Controls.Add(this.lblEmail);
			this.tpGeneral.Controls.Add(this.tbPhoneNumber);
			this.tpGeneral.Controls.Add(this.label1);
			this.tpGeneral.Controls.Add(this.tbOffice);
			this.tpGeneral.Controls.Add(this.lblOffice);
			this.tpGeneral.Controls.Add(this.tbDescription);
			this.tpGeneral.Controls.Add(this.lblDescription);
			this.tpGeneral.Controls.Add(this.tbDisplayName);
			this.tpGeneral.Controls.Add(this.lblDisplayName);
			this.tpGeneral.Controls.Add(this.tbLastName);
			this.tpGeneral.Controls.Add(this.lblLastName);
			this.tpGeneral.Controls.Add(this.tbMiddleInitial);
			this.tpGeneral.Controls.Add(this.lblMiddleInitial);
			this.tpGeneral.Controls.Add(this.tbFirstName);
			this.tpGeneral.Controls.Add(this.lblFirstName);
			this.tpGeneral.Controls.Add(this.lblName);
			this.tpGeneral.Location = new System.Drawing.Point(4, 22);
			this.tpGeneral.Name = "tpGeneral";
			this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tpGeneral.Size = new System.Drawing.Size(431, 380);
			this.tpGeneral.TabIndex = 0;
			this.tpGeneral.Text = "General";
			this.tpGeneral.UseVisualStyleBackColor = true;
			// 
			// tbWebpage
			// 
			this.tbWebpage.Location = new System.Drawing.Point(115, 327);
			this.tbWebpage.Name = "tbWebpage";
			this.tbWebpage.Size = new System.Drawing.Size(299, 20);
			this.tbWebpage.TabIndex = 18;
			this.tbWebpage.Text = "NotBoundToProperty!";
			// 
			// lblWebpage
			// 
			this.lblWebpage.AutoSize = true;
			this.lblWebpage.Location = new System.Drawing.Point(12, 330);
			this.lblWebpage.Name = "lblWebpage";
			this.lblWebpage.Size = new System.Drawing.Size(57, 13);
			this.lblWebpage.TabIndex = 17;
			this.lblWebpage.Text = "&Web page";
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(114, 295);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(299, 20);
			this.tbEmail.TabIndex = 16;
			this.tbEmail.Text = "NotBoundToProperty!";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(11, 298);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 15;
			this.lblEmail.Text = "E-&mail";
			// 
			// tbPhoneNumber
			// 
			this.tbPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "VoiceTelephoneNumber", true));
			this.tbPhoneNumber.Location = new System.Drawing.Point(114, 265);
			this.tbPhoneNumber.Name = "tbPhoneNumber";
			this.tbPhoneNumber.Size = new System.Drawing.Size(299, 20);
			this.tbPhoneNumber.TabIndex = 14;
			// 
			// userPrincipalBindingSource
			// 
			this.userPrincipalBindingSource.DataSource = typeof(System.DirectoryServices.AccountManagement.UserPrincipal);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 268);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "&Telephone number";
			// 
			// tbOffice
			// 
			this.tbOffice.Location = new System.Drawing.Point(114, 217);
			this.tbOffice.Name = "tbOffice";
			this.tbOffice.Size = new System.Drawing.Size(298, 20);
			this.tbOffice.TabIndex = 12;
			this.tbOffice.Text = "NotBoundToProperty!";
			// 
			// lblOffice
			// 
			this.lblOffice.AutoSize = true;
			this.lblOffice.Location = new System.Drawing.Point(11, 220);
			this.lblOffice.Name = "lblOffice";
			this.lblOffice.Size = new System.Drawing.Size(35, 13);
			this.lblOffice.TabIndex = 11;
			this.lblOffice.Text = "&Office";
			// 
			// tbDescription
			// 
			this.tbDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "Description", true));
			this.tbDescription.Location = new System.Drawing.Point(114, 179);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(298, 20);
			this.tbDescription.TabIndex = 10;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(11, 182);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 9;
			this.lblDescription.Text = "&Description";
			// 
			// tbDisplayName
			// 
			this.tbDisplayName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "DisplayName", true));
			this.tbDisplayName.Location = new System.Drawing.Point(114, 142);
			this.tbDisplayName.Name = "tbDisplayName";
			this.tbDisplayName.Size = new System.Drawing.Size(298, 20);
			this.tbDisplayName.TabIndex = 8;
			// 
			// lblDisplayName
			// 
			this.lblDisplayName.AutoSize = true;
			this.lblDisplayName.Location = new System.Drawing.Point(11, 145);
			this.lblDisplayName.Name = "lblDisplayName";
			this.lblDisplayName.Size = new System.Drawing.Size(72, 13);
			this.lblDisplayName.TabIndex = 7;
			this.lblDisplayName.Text = "&Display Name";
			// 
			// tbLastName
			// 
			this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "Surname", true));
			this.tbLastName.Location = new System.Drawing.Point(114, 103);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(298, 20);
			this.tbLastName.TabIndex = 6;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(11, 106);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(58, 13);
			this.lblLastName.TabIndex = 5;
			this.lblLastName.Text = "&Last Name";
			// 
			// tbMiddleInitial
			// 
			this.tbMiddleInitial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "MiddleName", true));
			this.tbMiddleInitial.Location = new System.Drawing.Point(314, 72);
			this.tbMiddleInitial.Name = "tbMiddleInitial";
			this.tbMiddleInitial.Size = new System.Drawing.Size(99, 20);
			this.tbMiddleInitial.TabIndex = 4;
			// 
			// lblMiddleInitial
			// 
			this.lblMiddleInitial.AutoSize = true;
			this.lblMiddleInitial.Location = new System.Drawing.Point(272, 75);
			this.lblMiddleInitial.Name = "lblMiddleInitial";
			this.lblMiddleInitial.Size = new System.Drawing.Size(36, 13);
			this.lblMiddleInitial.TabIndex = 3;
			this.lblMiddleInitial.Text = "&Initials";
			// 
			// tbFirstName
			// 
			this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "GivenName", true));
			this.tbFirstName.Location = new System.Drawing.Point(114, 72);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(152, 20);
			this.tbFirstName.TabIndex = 2;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(12, 75);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(57, 13);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "&First Name";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "Name", true));
			this.lblName.Location = new System.Drawing.Point(57, 29);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(51, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "FullName";
			// 
			// tpAddress
			// 
			this.tpAddress.Location = new System.Drawing.Point(4, 22);
			this.tpAddress.Name = "tpAddress";
			this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
			this.tpAddress.Size = new System.Drawing.Size(431, 380);
			this.tpAddress.TabIndex = 1;
			this.tpAddress.Text = "Address";
			this.tpAddress.UseVisualStyleBackColor = true;
			// 
			// tpAccount
			// 
			this.tpAccount.Controls.Add(this.gbAccountExpiry);
			this.tpAccount.Controls.Add(this.clbAccountOptions);
			this.tpAccount.Location = new System.Drawing.Point(4, 22);
			this.tpAccount.Name = "tpAccount";
			this.tpAccount.Size = new System.Drawing.Size(431, 380);
			this.tpAccount.TabIndex = 2;
			this.tpAccount.Text = "Account";
			this.tpAccount.UseVisualStyleBackColor = true;
			// 
			// gbAccountExpiry
			// 
			this.gbAccountExpiry.Controls.Add(this.dtpExpiry);
			this.gbAccountExpiry.Controls.Add(this.rbAtTheEndOf);
			this.gbAccountExpiry.Controls.Add(this.rbExpiresNever);
			this.gbAccountExpiry.Location = new System.Drawing.Point(8, 275);
			this.gbAccountExpiry.Name = "gbAccountExpiry";
			this.gbAccountExpiry.Size = new System.Drawing.Size(415, 102);
			this.gbAccountExpiry.TabIndex = 1;
			this.gbAccountExpiry.TabStop = false;
			this.gbAccountExpiry.Text = "Account expires";
			// 
			// dtpExpiry
			// 
			this.dtpExpiry.Location = new System.Drawing.Point(150, 38);
			this.dtpExpiry.Name = "dtpExpiry";
			this.dtpExpiry.Size = new System.Drawing.Size(244, 20);
			this.dtpExpiry.TabIndex = 2;
			// 
			// rbAtTheEndOf
			// 
			this.rbAtTheEndOf.AutoSize = true;
			this.rbAtTheEndOf.Location = new System.Drawing.Point(6, 42);
			this.rbAtTheEndOf.Name = "rbAtTheEndOf";
			this.rbAtTheEndOf.Size = new System.Drawing.Size(86, 17);
			this.rbAtTheEndOf.TabIndex = 1;
			this.rbAtTheEndOf.TabStop = true;
			this.rbAtTheEndOf.Text = "At the end of";
			this.rbAtTheEndOf.UseVisualStyleBackColor = true;
			this.rbAtTheEndOf.CheckedChanged += new System.EventHandler(this.ExpiryCheckedChanged);
			// 
			// rbExpiresNever
			// 
			this.rbExpiresNever.AutoSize = true;
			this.rbExpiresNever.Location = new System.Drawing.Point(6, 19);
			this.rbExpiresNever.Name = "rbExpiresNever";
			this.rbExpiresNever.Size = new System.Drawing.Size(54, 17);
			this.rbExpiresNever.TabIndex = 0;
			this.rbExpiresNever.TabStop = true;
			this.rbExpiresNever.Text = "Never";
			this.rbExpiresNever.UseVisualStyleBackColor = true;
			this.rbExpiresNever.CheckedChanged += new System.EventHandler(this.ExpiryCheckedChanged);
			// 
			// clbAccountOptions
			// 
			this.clbAccountOptions.FormattingEnabled = true;
			this.clbAccountOptions.Items.AddRange(new object[] {
            "User must change password at next logon",
            "User cannot change password",
            "Password never expires",
            "Store password using reversible encryption",
            "Account is disabled",
            "Smart card is required for interactive login",
            "Account is trusted for delegation",
            "Account is sensitive and cannot be delegated",
            "Use DES encryption types for this account",
            "This account supports Kerberos AES 128 bit encryption",
            "This account supports Kerberos AES 256 bit encryption",
            "Do not require Kerberos preauthentication"});
			this.clbAccountOptions.Location = new System.Drawing.Point(8, 196);
			this.clbAccountOptions.Name = "clbAccountOptions";
			this.clbAccountOptions.Size = new System.Drawing.Size(415, 64);
			this.clbAccountOptions.TabIndex = 0;
			this.clbAccountOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbAccountOptions_ItemCheck);
			// 
			// tpMemberOf
			// 
			this.tpMemberOf.Location = new System.Drawing.Point(4, 22);
			this.tpMemberOf.Name = "tpMemberOf";
			this.tpMemberOf.Size = new System.Drawing.Size(431, 380);
			this.tpMemberOf.TabIndex = 3;
			this.tpMemberOf.Text = "Member Of";
			this.tpMemberOf.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.TCUserProperties);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnOK);
			this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
			this.splitContainer1.Panel2.Controls.Add(this.btnApply);
			this.splitContainer1.Size = new System.Drawing.Size(439, 455);
			this.splitContainer1.SplitterDistance = 406;
			this.splitContainer1.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(190, 10);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(271, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnApply
			// 
			this.btnApply.Enabled = false;
			this.btnApply.Location = new System.Drawing.Point(352, 10);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(75, 23);
			this.btnApply.TabIndex = 0;
			this.btnApply.Text = "&Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			// 
			// UserConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(439, 455);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserConfigForm";
			this.Text = "User Properties";
			this.TCUserProperties.ResumeLayout(false);
			this.tpGeneral.ResumeLayout(false);
			this.tpGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPrincipalBindingSource)).EndInit();
			this.tpAccount.ResumeLayout(false);
			this.gbAccountExpiry.ResumeLayout(false);
			this.gbAccountExpiry.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TCUserProperties;
		private System.Windows.Forms.TabPage tpGeneral;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.BindingSource userPrincipalBindingSource;
		private System.Windows.Forms.TabPage tpAddress;
		private System.Windows.Forms.TextBox tbOffice;
		private System.Windows.Forms.Label lblOffice;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbDisplayName;
		private System.Windows.Forms.Label lblDisplayName;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox tbMiddleInitial;
		private System.Windows.Forms.Label lblMiddleInitial;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.TextBox tbWebpage;
		private System.Windows.Forms.Label lblWebpage;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox tbPhoneNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tpAccount;
		private System.Windows.Forms.CheckedListBox clbAccountOptions;
		private System.Windows.Forms.TabPage tpMemberOf;
		private System.Windows.Forms.GroupBox gbAccountExpiry;
		private System.Windows.Forms.DateTimePicker dtpExpiry;
		private System.Windows.Forms.RadioButton rbAtTheEndOf;
		private System.Windows.Forms.RadioButton rbExpiresNever;
	}
}