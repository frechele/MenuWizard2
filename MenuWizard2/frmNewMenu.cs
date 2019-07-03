using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuWizard2
{
	public partial class frmNewMenu : Form
	{
		public string Title
		{
			get; private set;
		}

		public int Weight
		{
			get; private set;
		}

		public frmNewMenu()
		{
			InitializeComponent();
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (txtTitle.Text == string.Empty)
			{
				MessageBox.Show("종목 이름을 입력해주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Title = txtTitle.Text;
			Weight = (int)nudWeight.Value;

			DialogResult = DialogResult.OK;
		}
	}
}
