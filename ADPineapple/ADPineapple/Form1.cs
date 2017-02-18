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
				DGVUsers.SelectedRows[0].DataBoundItem;
			}
		}
	}
}
