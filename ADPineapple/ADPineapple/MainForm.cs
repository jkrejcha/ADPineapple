using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPineapple
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void DGVUsers_DoubleClick(object sender, EventArgs e)
		{
			if (DGVUsers.SelectedRows.Count > 0)
			{
				UserConfigForm userConfig = new UserConfigForm();
				userConfig.Show((UserPrincipal)DGVUsers.SelectedRows[0].DataBoundItem);
			}
		}

		private void DGVUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			if (Dialogs.ShowDialog(DialogType.DeleteUserWarning).Result == TaskDialogInterop.TaskDialogSimpleResult.Yes)
			{
				
			}
			else
			{
				e.Cancel = true;
			}
		}
	}
}
