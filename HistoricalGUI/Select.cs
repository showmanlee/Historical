using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HistoricalGUI
{
	public partial class Select : Form
	{
		int who;
		public Select(int wh)
		{
			who = wh;
			InitializeComponent();
		}

		private void Select_Load(object sender, EventArgs e)
		{
			if (who == 1)
				name.Text = "이은섭 훈장";
			else if (who == 2)
				name.Text = "이정훈 훈장";
			else if (who == 3)
				name.Text = "이정주 훈장";
			for (int i = 1; ; i++)
			{
				string txt = "data\\";
				switch (who)
				{
					case 1:
						txt += "es";
						break;
					case 2:
						txt += "jh";
						break;
					case 3:
						txt += "jj";
						break;
				}
				txt += i.ToString() + ".txt";
				try
				{
					StreamReader r = new StreamReader(txt, Encoding.Default);
					txt = r.ReadLine();
					string title = (txt.Split(' ')[0]);
					listBox1.Items.Add(title.Replace('_', ' '));
					r.Close();
				}
				catch { break; }
			}
		}

		private void undo_Click(object sender, EventArgs e)
		{
			Form1 a = new Form1();
			a.Show();
			Hide();
		}

		private void Select_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
				Application.ExitThread();
			else
				e.Cancel = true;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				Browser c = new Browser(who, listBox1.SelectedIndex + 1);
				c.Show();
				Hide();
			}
		}
	}
}
