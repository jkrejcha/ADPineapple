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
	public partial class UserConfigForm : Form
	{
		public UserConfigForm()
		{
			InitializeComponent();
		}

		public void Show(UserPrincipal user)
		{
			this.userPrincipalBindingSource.DataSource = user;
			Show();
        }

		private void ExpiryCheckedChanged(object sender, EventArgs e)
		{
			dtpExpiry.Enabled = rbAtTheEndOf.Checked;
		}
	}
}
