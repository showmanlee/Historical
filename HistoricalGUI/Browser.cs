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
	public partial class Browser : Form
	{
		int who, txt;
		int pages;
		string locate;
		public Browser(int wh, int tx)
		{
			who = wh;
			txt = tx;
			InitializeComponent();
		}
		private void Browser_Load(object sender, EventArgs e)
		{
			if (who == 1)
				Browse.Text = "이은섭 훈장";
			else if (who == 2)
				Browse.Text = "이정훈 훈장";
			else if (who == 3)
				Browse.Text = "이정주 훈장";

			locate = "data\\";
			if (who == 1)
				locate += "es";
			else if (who == 2)
				locate += "jh";
			else if (who == 3)
				locate += "jj";
			locate += txt.ToString() + ".txt";

			StreamReader r = new StreamReader(locate, Encoding.Default);
			string tt = r.ReadLine();
			Browse.Text += " > " + tt.Split(' ')[0].Replace('_', ' ');
			pages = Convert.ToInt32(tt.Split(' ')[1]);
			r.ReadLine();

			defs.Text = "";
			while (true)
			{
				if (r.Peek() == '+')
					break;
				defs.Text += r.ReadLine() + "\r\n";
			}
			r.Close();

			StreamReader r2 = new StreamReader(locate, Encoding.Default);
			int repeat = 0;
			while (repeat < pages)
			{
				if (r2.ReadLine() == "+")
				{
					index.Items.Add(r2.ReadLine());
					repeat++;
				}
			}
			r2.Close();
			try
			{
				string s = "photo\\";
				if (who == 1)
					s += "es";
				else if (who == 2)
					s += "jh";
				else if (who == 3)
					s += "jj";
				s += txt.ToString();
				s += "1";
				s += ".jpg";
				photo.Load(s);
			}
			catch
			{
				photo.Load("photo\\def.jpg");
			};
			index.SelectedIndex = 0;
			page.Text = (index.SelectedIndex + 1).ToString() + "/" + pages.ToString();
		}

		private void Browser_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
				Application.ExitThread();
			else
				e.Cancel = true;
		}

		private void gotolecture_Click(object sender, EventArgs e)
		{
			Select a = new Select(who);
			a.Show();
			Hide();
		}

		private void index_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (index.SelectedIndex != -1)
			{
				StreamReader r = new StreamReader(locate, Encoding.Default);
				defs.Text = "";
				int counter = 0;
				while (true)
				{
					if (r.ReadLine() == "+")
						counter++;
					if (counter == index.SelectedIndex + 1)
						break;
				}
				while (true)
				{
					if (r.Peek() == '+' || r.EndOfStream)
						break;
					else
						defs.Text += r.ReadLine() + "\r\n";
				}
				r.Close();
				progressBar1.Value = 100 / (pages - 1) * index.SelectedIndex;
				if (progressBar1.Value >= 95)
				{
					progressBar1.Value = 100;
					gotoquiz.Enabled = true;
				}
				else
					gotoquiz.Enabled = false;
			}
			try
			{
				string s = "photo\\";
				if (who == 1)
					s += "es";
				else if (who == 2)
					s += "jh";
				else if (who == 3)
					s += "jj";
				s += txt.ToString();
				s += (index.SelectedIndex + 1).ToString();
				s += ".jpg";
				photo.Load(s);
			}
			catch
			{
				photo.Load("photo\\def.jpg");
			};
			page.Text = (index.SelectedIndex + 1).ToString() + "/" + pages.ToString();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			List<string> easteregg = new List<string>();
			StreamReader a = new StreamReader("data\\easter.txt", Encoding.Default);
			while (!a.EndOfStream)
				easteregg.Add(a.ReadLine());
			a.Close();
			Random r = new Random();
			MessageBox.Show(easteregg[r.Next(0, easteregg.Count)], "훈장님의 한 마디!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}


		private void backpage_Click(object sender, EventArgs e)
		{
			try
			{
				if (index.SelectedIndex == -1)
					index.SelectedIndex = 0;
				else
					index.SelectedIndex--;
			}
			catch
			{
				index.SelectedIndex = 0;
			}
		}

		private void nextpage_Click(object sender, EventArgs e)
		{
			try
			{
				index.SelectedIndex++;
			}
			catch
			{
				index.SelectedIndex = pages - 1;
			}
		}

		private void gotoquiz_Click(object sender, EventArgs e)
		{
			quiz a = new quiz(who, txt, Browse.Text);
			a.Show();
		}

		private void gotoanother_Click(object sender, EventArgs e)
		{
			Form1 a = new Form1();
			a.Show();
			Hide();
		}
	}
}
