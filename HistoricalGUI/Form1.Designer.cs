namespace HistoricalGUI
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.title = new System.Windows.Forms.Label();
			this.copyright = new System.Windows.Forms.Label();
			this.button_es = new System.Windows.Forms.Button();
			this.button_jh = new System.Windows.Forms.Button();
			this.button_jj = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("궁서", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.title.Location = new System.Drawing.Point(12, 14);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(452, 37);
			this.title.TabIndex = 0;
			this.title.Text = "이 훈장님들의 역사 강의!";
			// 
			// copyright
			// 
			this.copyright.AutoSize = true;
			this.copyright.Location = new System.Drawing.Point(347, 272);
			this.copyright.Name = "copyright";
			this.copyright.Size = new System.Drawing.Size(113, 12);
			this.copyright.TabIndex = 1;
			this.copyright.Text = "ⓒ 2017 이 훈장님들";
			// 
			// button_es
			// 
			this.button_es.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_es.Location = new System.Drawing.Point(12, 110);
			this.button_es.Name = "button_es";
			this.button_es.Size = new System.Drawing.Size(137, 152);
			this.button_es.TabIndex = 2;
			this.button_es.Text = "이은섭\r\n\r\n고려시대";
			this.button_es.UseVisualStyleBackColor = true;
			this.button_es.Click += new System.EventHandler(this.button_es_Click);
			// 
			// button_jh
			// 
			this.button_jh.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_jh.Location = new System.Drawing.Point(168, 110);
			this.button_jh.Name = "button_jh";
			this.button_jh.Size = new System.Drawing.Size(137, 152);
			this.button_jh.TabIndex = 2;
			this.button_jh.Text = "이정훈\r\n\r\n조선 전기";
			this.button_jh.UseVisualStyleBackColor = true;
			this.button_jh.Click += new System.EventHandler(this.button_jh_Click);
			// 
			// button_jj
			// 
			this.button_jj.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button_jj.Location = new System.Drawing.Point(323, 110);
			this.button_jj.Name = "button_jj";
			this.button_jj.Size = new System.Drawing.Size(137, 152);
			this.button_jj.TabIndex = 2;
			this.button_jj.Text = "이정주\r\n\r\n조선 후기";
			this.button_jj.UseVisualStyleBackColor = true;
			this.button_jj.Click += new System.EventHandler(this.button_jj_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Help;
			this.label1.Font = new System.Drawing.Font("궁서", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(92, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(291, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "훈장을 선택하십시오...";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// exit
			// 
			this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exit.Location = new System.Drawing.Point(203, 268);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(62, 20);
			this.exit.TabIndex = 4;
			this.exit.Text = "종료";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.exit;
			this.ClientSize = new System.Drawing.Size(472, 300);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_jj);
			this.Controls.Add(this.button_jh);
			this.Controls.Add(this.button_es);
			this.Controls.Add(this.copyright);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "이 훈장님들의 역사 강의";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label copyright;
		private System.Windows.Forms.Button button_es;
		private System.Windows.Forms.Button button_jh;
		private System.Windows.Forms.Button button_jj;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button exit;
	}
}

