using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoricalGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
				Application.ExitThread();
		}

		private void button_es_Click(object sender, EventArgs e)
		{
			Select b = new Select(1);
			b.Show();
			Hide();
			if (b.Visible == false)
				Show();
		}

		private void button_jh_Click(object sender, EventArgs e)
		{
			Select b = new Select(2);
			b.Show();
			Hide();
			if (b.Visible == false)
				Show();
		}

		private void button_jj_Click(object sender, EventArgs e)
		{
			Select b = new Select(3);
			b.Show();
			Hide();
			if (b.Visible == false)
				Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			label1.Text = "여기 말고, 버튼을요!";
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
				Application.ExitThread();
			else
				e.Cancel = true;
		}
	}
}
