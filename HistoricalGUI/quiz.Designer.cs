namespace HistoricalGUI
{
	partial class quiz
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quiz));
			this.browse = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.ansnum = new System.Windows.Forms.ListBox();
			this.question = new System.Windows.Forms.TextBox();
			this.answord = new System.Windows.Forms.TextBox();
			this.submit = new System.Windows.Forms.Button();
			this.answer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// browse
			// 
			this.browse.AutoSize = true;
			this.browse.Font = new System.Drawing.Font("굴림", 14F);
			this.browse.Location = new System.Drawing.Point(118, 10);
			this.browse.Name = "browse";
			this.browse.Size = new System.Drawing.Size(55, 19);
			this.browse.TabIndex = 0;
			this.browse.Text = "label1";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 265);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(651, 23);
			this.progressBar1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 145);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(572, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 22);
			this.button1.TabIndex = 3;
			this.button1.Text = "닫기";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(12, 162);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(100, 100);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
			// 
			// ansnum
			// 
			this.ansnum.Font = new System.Drawing.Font("굴림", 12F);
			this.ansnum.FormattingEnabled = true;
			this.ansnum.HorizontalScrollbar = true;
			this.ansnum.ItemHeight = 16;
			this.ansnum.Location = new System.Drawing.Point(122, 162);
			this.ansnum.Name = "ansnum";
			this.ansnum.Size = new System.Drawing.Size(250, 100);
			this.ansnum.TabIndex = 5;
			// 
			// question
			// 
			this.question.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.question.Location = new System.Drawing.Point(122, 37);
			this.question.Multiline = true;
			this.question.Name = "question";
			this.question.ReadOnly = true;
			this.question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.question.Size = new System.Drawing.Size(541, 119);
			this.question.TabIndex = 6;
			this.question.TextChanged += new System.EventHandler(this.question_TextChanged);
			// 
			// answord
			// 
			this.answord.Font = new System.Drawing.Font("굴림", 14F);
			this.answord.Location = new System.Drawing.Point(378, 162);
			this.answord.Name = "answord";
			this.answord.Size = new System.Drawing.Size(285, 29);
			this.answord.TabIndex = 7;
			// 
			// submit
			// 
			this.submit.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.submit.Location = new System.Drawing.Point(378, 199);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(93, 64);
			this.submit.TabIndex = 8;
			this.submit.Text = "정답 확인";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.submit_Click);
			// 
			// answer
			// 
			this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.answer.AutoSize = true;
			this.answer.Font = new System.Drawing.Font("궁서", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.answer.Location = new System.Drawing.Point(485, 213);
			this.answer.Name = "answer";
			this.answer.Size = new System.Drawing.Size(172, 27);
			this.answer.TabIndex = 9;
			this.answer.Text = "과연 결과는?";
			// 
			// quiz
			// 
			this.AcceptButton = this.submit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Silver;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(675, 300);
			this.Controls.Add(this.answer);
			this.Controls.Add(this.submit);
			this.Controls.Add(this.answord);
			this.Controls.Add(this.question);
			this.Controls.Add(this.ansnum);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.browse);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "quiz";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "이 훈장님들의 역사 강의";
			this.TopMost = true;
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.quiz_HelpButtonClicked);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quiz_FormClosing);
			this.Load += new System.EventHandler(this.quiz_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label browse;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox ansnum;
		private System.Windows.Forms.TextBox question;
		private System.Windows.Forms.TextBox answord;
		private System.Windows.Forms.Button submit;
		private System.Windows.Forms.Label answer;
	}
}