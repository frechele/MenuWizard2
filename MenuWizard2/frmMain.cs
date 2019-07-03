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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			frmNewMenu frm = new frmNewMenu();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				ListViewItem lvi = new ListViewItem(frm.Title);
				lvi.SubItems.Add(frm.Weight.ToString());

				lstView.Items.Add(lvi);
			}
		}

		private void BtnRemove_Click(object sender, EventArgs e)
		{
			if (lstView.SelectedItems == null)
			{
				MessageBox.Show("제거할 대상을 선택해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			lstView.Items.Remove(lstView.SelectedItems[0]);
		}

		private void BtnSum_Click(object sender, EventArgs e)
		{
			if (lstView.Items.Count == 0)
			{
				MessageBox.Show("종목을 추가해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			double[] Values = new double[lstView.Items.Count];
			double total = 0;
			
			Random rand = new Random();

			for (int i = 0; i < lstView.Items.Count; ++i)
			{
				Values[i] = 0.75 + Convert.ToDouble(lstView.Items[i].SubItems[1].Text) / 10 + 0.25 * rand.NextDouble();
				total += Values[i];
			}

			for (int i = 0; i < lstView.Items.Count; ++i)
				Values[i] /= total;

			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < lstView.Items.Count; ++i)
			{
				builder.Append(lstView.Items[i].SubItems[0].Text + " : ");
				builder.Append((Values[i] * 100).ToString());
				builder.Append("%");
				builder.Append("\r\n");
			}

			MessageBox.Show(builder.ToString(), "결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
