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
	public partial class quiz : Form
	{
		int who, txt, quizs = 0;
		string now, locate;
		string dab;
		List<bool> result = new List<bool>();
		public quiz(int wh, int tx, string no)
		{
			who = wh;
			txt = tx;
			now = no;
			InitializeComponent();
		}

		private void quiz_Load(object sender, EventArgs e)
		{
			browse.Text = now;
			locate = "quiz\\";
			if (who == 1)
				locate += "es";
			else if (who == 2)
				locate += "jh";
			else if (who == 3)
				locate += "jj";
			locate += txt.ToString() + ".txt";
			StreamReader r = new StreamReader(locate, Encoding.Default);
			while (!r.EndOfStream)
			{
				if (r.Peek() == '+')
				{
					quizs++;
					listBox1.Items.Add("문제 " + quizs.ToString());
					result.Add(false);
				}
				r.ReadLine();
			}
			listBox1.SelectedIndex = 0;
			r.Close();
		}

		private void submit_Click(object sender, EventArgs e)
		{
			if (ansnum.Enabled)
			{
				if (Convert.ToInt32(dab) - 1 == ansnum.SelectedIndex)
				{
					answer.Text = "정답입니다!";
					answer.ForeColor = Color.DarkGreen;
					result[listBox1.SelectedIndex] = true;
					listBox1.SelectedValue = "문제 " + (listBox1.SelectedIndex + 1).ToString() + " - O";
				}
				else
				{
					answer.Text = "틀렸습니다.";
					answer.ForeColor = Color.DarkRed;
					listBox1.SelectedValue = "문제 " + (listBox1.SelectedIndex + 1).ToString() + " - X";
				}
			}
			else
			{
				if (dab == answord.Text)
				{
					answer.Text = "정답입니다!";
					answer.ForeColor = Color.DarkGreen;
					result[listBox1.SelectedIndex] = true;
					listBox1.SelectedValue = "문제 " + (listBox1.SelectedIndex + 1).ToString() + " - O";
				}
				else
				{
					answer.Text = "틀렸습니다.";
					answer.ForeColor = Color.DarkRed;
					listBox1.SelectedValue = "문제 " + (listBox1.SelectedIndex + 1).ToString() + " - X";
				}
			}
			progressBar1.Value = 0;
			foreach(bool b in result)
			{
				if (b)
					progressBar1.Value += 100 / quizs;
			}
			if (!result.Contains(false))
				progressBar1.Value = 100;
			listBox1.Refresh();
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

		private void question_TextChanged(object sender, EventArgs e)
		{

		}

		private void quiz_HelpButtonClicked(object sender, CancelEventArgs e)
		{

		}

		private void listBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			listBox1.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ansnum.Items.Clear();
			answord.Text = "";
			question.Text = "";
			answer.Text = "과연 결과는?";
			answer.ForeColor = Color.Black;
			browse.Text = now + " > 문제 " + (listBox1.SelectedIndex + 1).ToString();
			StreamReader r = new StreamReader(locate, Encoding.Default);
			int counter = 0;
			while (counter <= listBox1.SelectedIndex)
				if (r.ReadLine() == "+")
					counter++;
			if (r.ReadLine() == "객관식")
			{
				ansnum.Enabled = true;
				answord.Enabled = false;
			}
			else
			{
				ansnum.Enabled = false;
				answord.Enabled = true;
			}
			while (r.Peek() != '=')
				question.Text += r.ReadLine() + "\r\n";
			r.ReadLine();
			if (ansnum.Enabled)
				while (r.Peek() != '|')
					ansnum.Items.Add(r.ReadLine());
			if (r.ReadLine() == "|")
				dab = r.ReadLine();
			r.Close();
		}

		private void quiz_FormClosing(object sender, FormClosingEventArgs e)
		{
			int counter = 0;
			foreach (bool b in result)
				if (b)
					counter++;
			MessageBox.Show("결과: " + counter.ToString() + "/" + quizs.ToString() + "\n" + (counter == quizs ? "아주 잘하셨습니다!" : "분발하세요!"), "문제풀이 종료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}
