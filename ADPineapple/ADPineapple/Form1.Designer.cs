namespace ADPineapple
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.TCMain = new System.Windows.Forms.TabControl();
			this.TPUsers = new System.Windows.Forms.TabPage();
			this.TPGroups = new System.Windows.Forms.TabPage();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.domainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.localComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DGVUsers = new System.Windows.Forms.DataGridView();
			this.userPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadColumnSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveColumnSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
			this.givenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.voiceTelephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.advancedSearchFilterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enabledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountLockoutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastLogonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.permittedLogonTimesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.accountExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smartcardLogonRequiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.delegationPermittedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.badLogonCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.homeDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.homeDriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.scriptPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastPasswordSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastBadPasswordAttemptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordNotRequiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.passwordNeverExpiresDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.userCannotChangePasswordDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.samAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userPrincipalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.distinguishedNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.structuralObjectClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.TCMain.SuspendLayout();
			this.TPUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userPrincipalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.viewToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// TCMain
			// 
			this.TCMain.Controls.Add(this.TPUsers);
			this.TCMain.Controls.Add(this.TPGroups);
			resources.ApplyResources(this.TCMain, "TCMain");
			this.TCMain.Name = "TCMain";
			this.TCMain.SelectedIndex = 0;
			// 
			// TPUsers
			// 
			this.TPUsers.Controls.Add(this.DGVUsers);
			resources.ApplyResources(this.TPUsers, "TPUsers");
			this.TPUsers.Name = "TPUsers";
			this.TPUsers.UseVisualStyleBackColor = true;
			// 
			// TPGroups
			// 
			resources.ApplyResources(this.TPGroups, "TPGroups");
			this.TPGroups.Name = "TPGroups";
			this.TPGroups.UseVisualStyleBackColor = true;
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domainToolStripMenuItem,
            this.localComputerToolStripMenuItem});
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
			// 
			// domainToolStripMenuItem
			// 
			this.domainToolStripMenuItem.Name = "domainToolStripMenuItem";
			resources.ApplyResources(this.domainToolStripMenuItem, "domainToolStripMenuItem");
			// 
			// localComputerToolStripMenuItem
			// 
			this.localComputerToolStripMenuItem.Name = "localComputerToolStripMenuItem";
			resources.ApplyResources(this.localComputerToolStripMenuItem, "localComputerToolStripMenuItem");
			// 
			// DGVUsers
			// 
			this.DGVUsers.AutoGenerateColumns = false;
			this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.givenNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.voiceTelephoneNumberDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.advancedSearchFilterDataGridViewTextBoxColumn,
            this.enabledDataGridViewTextBoxColumn,
            this.accountLockoutTimeDataGridViewTextBoxColumn,
            this.lastLogonDataGridViewTextBoxColumn,
            this.permittedLogonTimesDataGridViewImageColumn,
            this.accountExpirationDateDataGridViewTextBoxColumn,
            this.smartcardLogonRequiredDataGridViewCheckBoxColumn,
            this.delegationPermittedDataGridViewCheckBoxColumn,
            this.badLogonCountDataGridViewTextBoxColumn,
            this.homeDirectoryDataGridViewTextBoxColumn,
            this.homeDriveDataGridViewTextBoxColumn,
            this.scriptPathDataGridViewTextBoxColumn,
            this.lastPasswordSetDataGridViewTextBoxColumn,
            this.lastBadPasswordAttemptDataGridViewTextBoxColumn,
            this.passwordNotRequiredDataGridViewCheckBoxColumn,
            this.passwordNeverExpiresDataGridViewCheckBoxColumn,
            this.userCannotChangePasswordDataGridViewCheckBoxColumn,
            this.allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.displayNameDataGridViewTextBoxColumn,
            this.samAccountNameDataGridViewTextBoxColumn,
            this.userPrincipalNameDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.guidDataGridViewTextBoxColumn,
            this.distinguishedNameDataGridViewTextBoxColumn,
            this.structuralObjectClassDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
			this.DGVUsers.DataSource = this.userPrincipalBindingSource;
			resources.ApplyResources(this.DGVUsers, "DGVUsers");
			this.DGVUsers.Name = "DGVUsers";
			this.DGVUsers.DoubleClick += new System.EventHandler(this.DGVUsers_DoubleClick);
			// 
			// userPrincipalBindingSource
			// 
			this.userPrincipalBindingSource.DataSource = typeof(System.DirectoryServices.AccountManagement.UserPrincipal);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadColumnSetToolStripMenuItem,
            this.saveColumnSetToolStripMenuItem,
            this.selectColumnsToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
			// 
			// loadColumnSetToolStripMenuItem
			// 
			this.loadColumnSetToolStripMenuItem.Name = "loadColumnSetToolStripMenuItem";
			resources.ApplyResources(this.loadColumnSetToolStripMenuItem, "loadColumnSetToolStripMenuItem");
			// 
			// saveColumnSetToolStripMenuItem
			// 
			this.saveColumnSetToolStripMenuItem.Name = "saveColumnSetToolStripMenuItem";
			resources.ApplyResources(this.saveColumnSetToolStripMenuItem, "saveColumnSetToolStripMenuItem");
			// 
			// selectColumnsToolStripMenuItem
			// 
			this.selectColumnsToolStripMenuItem.Name = "selectColumnsToolStripMenuItem";
			resources.ApplyResources(this.selectColumnsToolStripMenuItem, "selectColumnsToolStripMenuItem");
			// 
			// ColumnIcon
			// 
			this.ColumnIcon.Frozen = true;
			resources.ApplyResources(this.ColumnIcon, "ColumnIcon");
			this.ColumnIcon.Name = "ColumnIcon";
			this.ColumnIcon.ReadOnly = true;
			// 
			// givenNameDataGridViewTextBoxColumn
			// 
			this.givenNameDataGridViewTextBoxColumn.DataPropertyName = "GivenName";
			resources.ApplyResources(this.givenNameDataGridViewTextBoxColumn, "givenNameDataGridViewTextBoxColumn");
			this.givenNameDataGridViewTextBoxColumn.Name = "givenNameDataGridViewTextBoxColumn";
			// 
			// middleNameDataGridViewTextBoxColumn
			// 
			this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
			resources.ApplyResources(this.middleNameDataGridViewTextBoxColumn, "middleNameDataGridViewTextBoxColumn");
			this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
			// 
			// surnameDataGridViewTextBoxColumn
			// 
			this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
			resources.ApplyResources(this.surnameDataGridViewTextBoxColumn, "surnameDataGridViewTextBoxColumn");
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			// 
			// emailAddressDataGridViewTextBoxColumn
			// 
			this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
			resources.ApplyResources(this.emailAddressDataGridViewTextBoxColumn, "emailAddressDataGridViewTextBoxColumn");
			this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
			// 
			// voiceTelephoneNumberDataGridViewTextBoxColumn
			// 
			this.voiceTelephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "VoiceTelephoneNumber";
			resources.ApplyResources(this.voiceTelephoneNumberDataGridViewTextBoxColumn, "voiceTelephoneNumberDataGridViewTextBoxColumn");
			this.voiceTelephoneNumberDataGridViewTextBoxColumn.Name = "voiceTelephoneNumberDataGridViewTextBoxColumn";
			// 
			// employeeIdDataGridViewTextBoxColumn
			// 
			this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
			resources.ApplyResources(this.employeeIdDataGridViewTextBoxColumn, "employeeIdDataGridViewTextBoxColumn");
			this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
			// 
			// advancedSearchFilterDataGridViewTextBoxColumn
			// 
			this.advancedSearchFilterDataGridViewTextBoxColumn.DataPropertyName = "AdvancedSearchFilter";
			resources.ApplyResources(this.advancedSearchFilterDataGridViewTextBoxColumn, "advancedSearchFilterDataGridViewTextBoxColumn");
			this.advancedSearchFilterDataGridViewTextBoxColumn.Name = "advancedSearchFilterDataGridViewTextBoxColumn";
			this.advancedSearchFilterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enabledDataGridViewTextBoxColumn
			// 
			this.enabledDataGridViewTextBoxColumn.DataPropertyName = "Enabled";
			resources.ApplyResources(this.enabledDataGridViewTextBoxColumn, "enabledDataGridViewTextBoxColumn");
			this.enabledDataGridViewTextBoxColumn.Name = "enabledDataGridViewTextBoxColumn";
			// 
			// accountLockoutTimeDataGridViewTextBoxColumn
			// 
			this.accountLockoutTimeDataGridViewTextBoxColumn.DataPropertyName = "AccountLockoutTime";
			resources.ApplyResources(this.accountLockoutTimeDataGridViewTextBoxColumn, "accountLockoutTimeDataGridViewTextBoxColumn");
			this.accountLockoutTimeDataGridViewTextBoxColumn.Name = "accountLockoutTimeDataGridViewTextBoxColumn";
			this.accountLockoutTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastLogonDataGridViewTextBoxColumn
			// 
			this.lastLogonDataGridViewTextBoxColumn.DataPropertyName = "LastLogon";
			resources.ApplyResources(this.lastLogonDataGridViewTextBoxColumn, "lastLogonDataGridViewTextBoxColumn");
			this.lastLogonDataGridViewTextBoxColumn.Name = "lastLogonDataGridViewTextBoxColumn";
			this.lastLogonDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// permittedLogonTimesDataGridViewImageColumn
			// 
			this.permittedLogonTimesDataGridViewImageColumn.DataPropertyName = "PermittedLogonTimes";
			resources.ApplyResources(this.permittedLogonTimesDataGridViewImageColumn, "permittedLogonTimesDataGridViewImageColumn");
			this.permittedLogonTimesDataGridViewImageColumn.Name = "permittedLogonTimesDataGridViewImageColumn";
			// 
			// accountExpirationDateDataGridViewTextBoxColumn
			// 
			this.accountExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "AccountExpirationDate";
			resources.ApplyResources(this.accountExpirationDateDataGridViewTextBoxColumn, "accountExpirationDateDataGridViewTextBoxColumn");
			this.accountExpirationDateDataGridViewTextBoxColumn.Name = "accountExpirationDateDataGridViewTextBoxColumn";
			// 
			// smartcardLogonRequiredDataGridViewCheckBoxColumn
			// 
			this.smartcardLogonRequiredDataGridViewCheckBoxColumn.DataPropertyName = "SmartcardLogonRequired";
			resources.ApplyResources(this.smartcardLogonRequiredDataGridViewCheckBoxColumn, "smartcardLogonRequiredDataGridViewCheckBoxColumn");
			this.smartcardLogonRequiredDataGridViewCheckBoxColumn.Name = "smartcardLogonRequiredDataGridViewCheckBoxColumn";
			// 
			// delegationPermittedDataGridViewCheckBoxColumn
			// 
			this.delegationPermittedDataGridViewCheckBoxColumn.DataPropertyName = "DelegationPermitted";
			resources.ApplyResources(this.delegationPermittedDataGridViewCheckBoxColumn, "delegationPermittedDataGridViewCheckBoxColumn");
			this.delegationPermittedDataGridViewCheckBoxColumn.Name = "delegationPermittedDataGridViewCheckBoxColumn";
			// 
			// badLogonCountDataGridViewTextBoxColumn
			// 
			this.badLogonCountDataGridViewTextBoxColumn.DataPropertyName = "BadLogonCount";
			resources.ApplyResources(this.badLogonCountDataGridViewTextBoxColumn, "badLogonCountDataGridViewTextBoxColumn");
			this.badLogonCountDataGridViewTextBoxColumn.Name = "badLogonCountDataGridViewTextBoxColumn";
			this.badLogonCountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// homeDirectoryDataGridViewTextBoxColumn
			// 
			this.homeDirectoryDataGridViewTextBoxColumn.DataPropertyName = "HomeDirectory";
			resources.ApplyResources(this.homeDirectoryDataGridViewTextBoxColumn, "homeDirectoryDataGridViewTextBoxColumn");
			this.homeDirectoryDataGridViewTextBoxColumn.Name = "homeDirectoryDataGridViewTextBoxColumn";
			// 
			// homeDriveDataGridViewTextBoxColumn
			// 
			this.homeDriveDataGridViewTextBoxColumn.DataPropertyName = "HomeDrive";
			resources.ApplyResources(this.homeDriveDataGridViewTextBoxColumn, "homeDriveDataGridViewTextBoxColumn");
			this.homeDriveDataGridViewTextBoxColumn.Name = "homeDriveDataGridViewTextBoxColumn";
			// 
			// scriptPathDataGridViewTextBoxColumn
			// 
			this.scriptPathDataGridViewTextBoxColumn.DataPropertyName = "ScriptPath";
			resources.ApplyResources(this.scriptPathDataGridViewTextBoxColumn, "scriptPathDataGridViewTextBoxColumn");
			this.scriptPathDataGridViewTextBoxColumn.Name = "scriptPathDataGridViewTextBoxColumn";
			// 
			// lastPasswordSetDataGridViewTextBoxColumn
			// 
			this.lastPasswordSetDataGridViewTextBoxColumn.DataPropertyName = "LastPasswordSet";
			resources.ApplyResources(this.lastPasswordSetDataGridViewTextBoxColumn, "lastPasswordSetDataGridViewTextBoxColumn");
			this.lastPasswordSetDataGridViewTextBoxColumn.Name = "lastPasswordSetDataGridViewTextBoxColumn";
			this.lastPasswordSetDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastBadPasswordAttemptDataGridViewTextBoxColumn
			// 
			this.lastBadPasswordAttemptDataGridViewTextBoxColumn.DataPropertyName = "LastBadPasswordAttempt";
			resources.ApplyResources(this.lastBadPasswordAttemptDataGridViewTextBoxColumn, "lastBadPasswordAttemptDataGridViewTextBoxColumn");
			this.lastBadPasswordAttemptDataGridViewTextBoxColumn.Name = "lastBadPasswordAttemptDataGridViewTextBoxColumn";
			this.lastBadPasswordAttemptDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordNotRequiredDataGridViewCheckBoxColumn
			// 
			this.passwordNotRequiredDataGridViewCheckBoxColumn.DataPropertyName = "PasswordNotRequired";
			resources.ApplyResources(this.passwordNotRequiredDataGridViewCheckBoxColumn, "passwordNotRequiredDataGridViewCheckBoxColumn");
			this.passwordNotRequiredDataGridViewCheckBoxColumn.Name = "passwordNotRequiredDataGridViewCheckBoxColumn";
			// 
			// passwordNeverExpiresDataGridViewCheckBoxColumn
			// 
			this.passwordNeverExpiresDataGridViewCheckBoxColumn.DataPropertyName = "PasswordNeverExpires";
			resources.ApplyResources(this.passwordNeverExpiresDataGridViewCheckBoxColumn, "passwordNeverExpiresDataGridViewCheckBoxColumn");
			this.passwordNeverExpiresDataGridViewCheckBoxColumn.Name = "passwordNeverExpiresDataGridViewCheckBoxColumn";
			// 
			// userCannotChangePasswordDataGridViewCheckBoxColumn
			// 
			this.userCannotChangePasswordDataGridViewCheckBoxColumn.DataPropertyName = "UserCannotChangePassword";
			resources.ApplyResources(this.userCannotChangePasswordDataGridViewCheckBoxColumn, "userCannotChangePasswordDataGridViewCheckBoxColumn");
			this.userCannotChangePasswordDataGridViewCheckBoxColumn.Name = "userCannotChangePasswordDataGridViewCheckBoxColumn";
			// 
			// allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn
			// 
			this.allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn.DataPropertyName = "AllowReversiblePasswordEncryption";
			resources.ApplyResources(this.allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn, "allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn");
			this.allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn.Name = "allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// displayNameDataGridViewTextBoxColumn
			// 
			this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
			resources.ApplyResources(this.displayNameDataGridViewTextBoxColumn, "displayNameDataGridViewTextBoxColumn");
			this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
			// 
			// samAccountNameDataGridViewTextBoxColumn
			// 
			this.samAccountNameDataGridViewTextBoxColumn.DataPropertyName = "SamAccountName";
			resources.ApplyResources(this.samAccountNameDataGridViewTextBoxColumn, "samAccountNameDataGridViewTextBoxColumn");
			this.samAccountNameDataGridViewTextBoxColumn.Name = "samAccountNameDataGridViewTextBoxColumn";
			// 
			// userPrincipalNameDataGridViewTextBoxColumn
			// 
			this.userPrincipalNameDataGridViewTextBoxColumn.DataPropertyName = "UserPrincipalName";
			resources.ApplyResources(this.userPrincipalNameDataGridViewTextBoxColumn, "userPrincipalNameDataGridViewTextBoxColumn");
			this.userPrincipalNameDataGridViewTextBoxColumn.Name = "userPrincipalNameDataGridViewTextBoxColumn";
			// 
			// sidDataGridViewTextBoxColumn
			// 
			this.sidDataGridViewTextBoxColumn.DataPropertyName = "Sid";
			resources.ApplyResources(this.sidDataGridViewTextBoxColumn, "sidDataGridViewTextBoxColumn");
			this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
			this.sidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// guidDataGridViewTextBoxColumn
			// 
			this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
			resources.ApplyResources(this.guidDataGridViewTextBoxColumn, "guidDataGridViewTextBoxColumn");
			this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
			this.guidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// distinguishedNameDataGridViewTextBoxColumn
			// 
			this.distinguishedNameDataGridViewTextBoxColumn.DataPropertyName = "DistinguishedName";
			resources.ApplyResources(this.distinguishedNameDataGridViewTextBoxColumn, "distinguishedNameDataGridViewTextBoxColumn");
			this.distinguishedNameDataGridViewTextBoxColumn.Name = "distinguishedNameDataGridViewTextBoxColumn";
			this.distinguishedNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// structuralObjectClassDataGridViewTextBoxColumn
			// 
			this.structuralObjectClassDataGridViewTextBoxColumn.DataPropertyName = "StructuralObjectClass";
			resources.ApplyResources(this.structuralObjectClassDataGridViewTextBoxColumn, "structuralObjectClassDataGridViewTextBoxColumn");
			this.structuralObjectClassDataGridViewTextBoxColumn.Name = "structuralObjectClassDataGridViewTextBoxColumn";
			this.structuralObjectClassDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TCMain);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.TCMain.ResumeLayout(false);
			this.TPUsers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userPrincipalBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem domainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem localComputerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadColumnSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveColumnSetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectColumnsToolStripMenuItem;
		private System.Windows.Forms.TabControl TCMain;
		private System.Windows.Forms.TabPage TPUsers;
		private System.Windows.Forms.DataGridView DGVUsers;
		private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
		private System.Windows.Forms.DataGridViewTextBoxColumn givenNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn voiceTelephoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn advancedSearchFilterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enabledDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountLockoutTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastLogonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn permittedLogonTimesDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountExpirationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn smartcardLogonRequiredDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn delegationPermittedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn badLogonCountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn homeDirectoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn homeDriveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn scriptPathDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastPasswordSetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastBadPasswordAttemptDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn passwordNotRequiredDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn passwordNeverExpiresDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn userCannotChangePasswordDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn allowReversiblePasswordEncryptionDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn samAccountNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userPrincipalNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn distinguishedNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn structuralObjectClassDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource userPrincipalBindingSource;
		private System.Windows.Forms.TabPage TPGroups;
	}
}

