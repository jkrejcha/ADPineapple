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
			this.TPGeneral = new System.Windows.Forms.TabPage();
			this.lblName = new System.Windows.Forms.Label();
			this.userPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.lblMiddleInitial = new System.Windows.Forms.Label();
			this.tbMiddleInitial = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.tbDisplayName = new System.Windows.Forms.TextBox();
			this.lblDisplayName = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbOffice = new System.Windows.Forms.TextBox();
			this.lblOffice = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.TCUserProperties.SuspendLayout();
			this.TPGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPrincipalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TCUserProperties
			// 
			this.TCUserProperties.Controls.Add(this.TPGeneral);
			this.TCUserProperties.Controls.Add(this.tabPage2);
			this.TCUserProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TCUserProperties.Location = new System.Drawing.Point(0, 0);
			this.TCUserProperties.Name = "TCUserProperties";
			this.TCUserProperties.SelectedIndex = 0;
			this.TCUserProperties.Size = new System.Drawing.Size(439, 406);
			this.TCUserProperties.TabIndex = 0;
			// 
			// TPGeneral
			// 
			this.TPGeneral.Controls.Add(this.tbOffice);
			this.TPGeneral.Controls.Add(this.lblOffice);
			this.TPGeneral.Controls.Add(this.tbDescription);
			this.TPGeneral.Controls.Add(this.lblDescription);
			this.TPGeneral.Controls.Add(this.tbDisplayName);
			this.TPGeneral.Controls.Add(this.lblDisplayName);
			this.TPGeneral.Controls.Add(this.tbLastName);
			this.TPGeneral.Controls.Add(this.lblLastName);
			this.TPGeneral.Controls.Add(this.tbMiddleInitial);
			this.TPGeneral.Controls.Add(this.lblMiddleInitial);
			this.TPGeneral.Controls.Add(this.tbFirstName);
			this.TPGeneral.Controls.Add(this.lblFirstName);
			this.TPGeneral.Controls.Add(this.lblName);
			this.TPGeneral.Location = new System.Drawing.Point(4, 22);
			this.TPGeneral.Name = "TPGeneral";
			this.TPGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.TPGeneral.Size = new System.Drawing.Size(431, 380);
			this.TPGeneral.TabIndex = 0;
			this.TPGeneral.Text = "General";
			this.TPGeneral.UseVisualStyleBackColor = true;
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
			// userPrincipalBindingSource
			// 
			this.userPrincipalBindingSource.DataSource = typeof(System.DirectoryServices.AccountManagement.UserPrincipal);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(449, 434);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
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
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(12, 75);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(57, 13);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "&First Name";
			// 
			// tbFirstName
			// 
			this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "GivenName", true));
			this.tbFirstName.Location = new System.Drawing.Point(100, 72);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(166, 20);
			this.tbFirstName.TabIndex = 2;
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
			// tbMiddleInitial
			// 
			this.tbMiddleInitial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "MiddleName", true));
			this.tbMiddleInitial.Location = new System.Drawing.Point(314, 72);
			this.tbMiddleInitial.Name = "tbMiddleInitial";
			this.tbMiddleInitial.Size = new System.Drawing.Size(99, 20);
			this.tbMiddleInitial.TabIndex = 4;
			// 
			// tbLastName
			// 
			this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "Surname", true));
			this.tbLastName.Location = new System.Drawing.Point(99, 103);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(313, 20);
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
			// tbDisplayName
			// 
			this.tbDisplayName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "DisplayName", true));
			this.tbDisplayName.Location = new System.Drawing.Point(99, 142);
			this.tbDisplayName.Name = "tbDisplayName";
			this.tbDisplayName.Size = new System.Drawing.Size(313, 20);
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
			// tbDescription
			// 
			this.tbDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPrincipalBindingSource, "Description", true));
			this.tbDescription.Location = new System.Drawing.Point(99, 179);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(313, 20);
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
			// tbOffice
			// 
			this.tbOffice.Location = new System.Drawing.Point(99, 217);
			this.tbOffice.Name = "tbOffice";
			this.tbOffice.Size = new System.Drawing.Size(313, 20);
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
			this.TPGeneral.ResumeLayout(false);
			this.TPGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPrincipalBindingSource)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TCUserProperties;
		private System.Windows.Forms.TabPage TPGeneral;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.BindingSource userPrincipalBindingSource;
		private System.Windows.Forms.TabPage tabPage2;
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
	}
}