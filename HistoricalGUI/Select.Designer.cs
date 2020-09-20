namespace HistoricalGUI
{
	partial class Select
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
			this.name = new System.Windows.Forms.Label();
			this.please = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.undo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.name.AutoSize = true;
			this.name.Font = new System.Drawing.Font("궁서", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.name.Location = new System.Drawing.Point(61, 9);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(156, 27);
			this.name.TabIndex = 0;
			this.name.Text = "이은섭 훈장";
			// 
			// please
			// 
			this.please.AutoSize = true;
			this.please.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.please.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.please.Location = new System.Drawing.Point(46, 46);
			this.please.Name = "please";
			this.please.Size = new System.Drawing.Size(197, 16);
			this.please.TabIndex = 1;
			this.please.Text = "강의를 선택하십시오...";
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("바탕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 21;
			this.listBox1.Location = new System.Drawing.Point(13, 79);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(254, 172);
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
			// 
			// undo
			// 
			this.undo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.undo.Location = new System.Drawing.Point(89, 257);
			this.undo.Name = "undo";
			this.undo.Size = new System.Drawing.Size(96, 24);
			this.undo.TabIndex = 3;
			this.undo.Text = "이전으로";
			this.undo.UseVisualStyleBackColor = true;
			this.undo.Click += new System.EventHandler(this.undo_Click);
			// 
			// Select
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.undo;
			this.ClientSize = new System.Drawing.Size(279, 288);
			this.Controls.Add(this.undo);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.please);
			this.Controls.Add(this.name);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Select";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "이 훈장님들의 역사 강의";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Select_FormClosing);
			this.Load += new System.EventHandler(this.Select_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label please;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button undo;
	}
}