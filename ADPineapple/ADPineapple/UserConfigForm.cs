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
		private UserPrincipal user => (UserPrincipal)userPrincipalBindingSource.DataSource;

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
			user.AccountExpirationDate = rbAtTheEndOf.Checked ? dtpExpiry.Value : (DateTime?)null;
		}

		private void clbAccountOptions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			// User Must Change Password at Logon, User cannot change password
			// Password never expires, Store using reversible encryption
			// Disabled, Smart card required for interactive, delegatable,
			// not delegatable, DES encryption types, supports Kerb AES 128, AES 256,
			// don't require Kerb preauth
			bool checkBoxChecked = e.NewValue == CheckState.Checked;
			switch (e.Index)
			{
				case 0:
					if (checkBoxChecked)
					{
						user.ExpirePasswordNow();
					}
					else
					{
						user.RefreshExpiredPassword();
					}
					break;
				case 1:
					user.UserCannotChangePassword = checkBoxChecked; break;
				case 2:
					user.PasswordNeverExpires = checkBoxChecked; break;
				case 3:
					user.AllowReversiblePasswordEncryption = checkBoxChecked; break;
				case 4:
					user.Enabled = !checkBoxChecked; break; // note: inverse of box check
				case 5:
					user.SmartcardLogonRequired = checkBoxChecked; break;
				case 6:
					user.DelegationPermitted = checkBoxChecked; break;
				case 7:
					user.DelegationPermitted = !checkBoxChecked; break;
				case 8:
				case 9:
				case 10:
				case 11:
					throw new NotImplementedException();
			}
		}
	}
}
