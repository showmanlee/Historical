namespace HistoricalGUI
{
	partial class Browser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Browse = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.gotoanother = new System.Windows.Forms.Button();
			this.defs = new System.Windows.Forms.TextBox();
			this.photo = new System.Windows.Forms.PictureBox();
			this.index = new System.Windows.Forms.ListBox();
			this.gotolecture = new System.Windows.Forms.Button();
			this.backpage = new System.Windows.Forms.Button();
			this.nextpage = new System.Windows.Forms.Button();
			this.gotoquiz = new System.Windows.Forms.Button();
			this.page = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 145);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// Browse
			// 
			this.Browse.AutoSize = true;
			this.Browse.Font = new System.Drawing.Font("굴림", 16F);
			this.Browse.Location = new System.Drawing.Point(119, 13);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(62, 22);
			this.Browse.TabIndex = 1;
			this.Browse.Text = "label1";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 426);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(760, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// gotoanother
			// 
			this.gotoanother.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.gotoanother.Location = new System.Drawing.Point(665, 12);
			this.gotoanother.Name = "gotoanother";
			this.gotoanother.Size = new System.Drawing.Size(107, 23);
			this.gotoanother.TabIndex = 4;
			this.gotoanother.Text = "다른 훈장에게로";
			this.gotoanother.UseVisualStyleBackColor = true;
			this.gotoanother.Click += new System.EventHandler(this.gotoanother_Click);
			// 
			// defs
			// 
			this.defs.BackColor = System.Drawing.Color.White;
			this.defs.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.defs.ForeColor = System.Drawing.SystemColors.InfoText;
			this.defs.Location = new System.Drawing.Point(123, 51);
			this.defs.Multiline = true;
			this.defs.Name = "defs";
			this.defs.ReadOnly = true;
			this.defs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.defs.Size = new System.Drawing.Size(316, 327);
			this.defs.TabIndex = 5;
			this.defs.Text = "align";
			// 
			// photo
			// 
			this.photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.photo.BackColor = System.Drawing.Color.White;
			this.photo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("photo.ErrorImage")));
			this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
			this.photo.Location = new System.Drawing.Point(445, 51);
			this.photo.Name = "photo";
			this.photo.Size = new System.Drawing.Size(327, 327);
			this.photo.TabIndex = 6;
			this.photo.TabStop = false;
			// 
			// index
			// 
			this.index.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.index.FormattingEnabled = true;
			this.index.ItemHeight = 16;
			this.index.Location = new System.Drawing.Point(12, 163);
			this.index.Name = "index";
			this.index.Size = new System.Drawing.Size(100, 260);
			this.index.TabIndex = 7;
			this.index.SelectedIndexChanged += new System.EventHandler(this.index_SelectedIndexChanged);
			// 
			// gotolecture
			// 
			this.gotolecture.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.gotolecture.Location = new System.Drawing.Point(557, 12);
			this.gotolecture.Name = "gotolecture";
			this.gotolecture.Size = new System.Drawing.Size(102, 23);
			this.gotolecture.TabIndex = 8;
			this.gotolecture.Text = "다른 강의로";
			this.gotolecture.UseVisualStyleBackColor = true;
			this.gotolecture.Click += new System.EventHandler(this.gotolecture_Click);
			// 
			// backpage
			// 
			this.backpage.Location = new System.Drawing.Point(123, 384);
			this.backpage.Name = "backpage";
			this.backpage.Size = new System.Drawing.Size(75, 39);
			this.backpage.TabIndex = 9;
			this.backpage.Text = "<<<";
			this.backpage.UseVisualStyleBackColor = true;
			this.backpage.Click += new System.EventHandler(this.backpage_Click);
			// 
			// nextpage
			// 
			this.nextpage.Location = new System.Drawing.Point(364, 384);
			this.nextpage.Name = "nextpage";
			this.nextpage.Size = new System.Drawing.Size(75, 39);
			this.nextpage.TabIndex = 9;
			this.nextpage.Text = ">>>";
			this.nextpage.UseVisualStyleBackColor = true;
			this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
			// 
			// gotoquiz
			// 
			this.gotoquiz.Enabled = false;
			this.gotoquiz.Font = new System.Drawing.Font("굴림", 16F);
			this.gotoquiz.Location = new System.Drawing.Point(620, 384);
			this.gotoquiz.Name = "gotoquiz";
			this.gotoquiz.Size = new System.Drawing.Size(152, 39);
			this.gotoquiz.TabIndex = 9;
			this.gotoquiz.Text = "문제 풀기";
			this.gotoquiz.UseVisualStyleBackColor = true;
			this.gotoquiz.Click += new System.EventHandler(this.gotoquiz_Click);
			// 
			// page
			// 
			this.page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.page.AutoSize = true;
			this.page.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.page.Location = new System.Drawing.Point(265, 396);
			this.page.Name = "page";
			this.page.Size = new System.Drawing.Size(50, 13);
			this.page.TabIndex = 10;
			this.page.Text = "label1";
			// 
			// Browser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.gotolecture;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.page);
			this.Controls.Add(this.gotoquiz);
			this.Controls.Add(this.nextpage);
			this.Controls.Add(this.backpage);
			this.Controls.Add(this.gotolecture);
			this.Controls.Add(this.index);
			this.Controls.Add(this.photo);
			this.Controls.Add(this.defs);
			this.Controls.Add(this.gotoanother);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Browser";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "이 훈장님들의 역사 강의";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browser_FormClosing);
			this.Load += new System.EventHandler(this.Browser_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label Browse;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button gotoanother;
		private System.Windows.Forms.TextBox defs;
		private System.Windows.Forms.PictureBox photo;
		private System.Windows.Forms.ListBox index;
		private System.Windows.Forms.Button gotolecture;
		private System.Windows.Forms.Button backpage;
		private System.Windows.Forms.Button nextpage;
		private System.Windows.Forms.Button gotoquiz;
		private System.Windows.Forms.Label page;
	}
}