using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPineapple
{
	public partial class ConnectionDialog : Form
	{
		public ConnectionDialog()
		{
			InitializeComponent();
		}

		private void RBConnection_CheckedChanged(object sender, EventArgs e)
		{
			txtBoxDomain.Enabled = RBConnectionDomain.Enabled;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{

		}
	}
}
