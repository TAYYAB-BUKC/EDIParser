namespace EDIParser
{
	partial class Form1
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
			this.Btn_EDIParser = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.Txt_Path = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Btn_EDIParser
			// 
			this.Btn_EDIParser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_EDIParser.Location = new System.Drawing.Point(492, 68);
			this.Btn_EDIParser.Name = "Btn_EDIParser";
			this.Btn_EDIParser.Size = new System.Drawing.Size(177, 45);
			this.Btn_EDIParser.TabIndex = 0;
			this.Btn_EDIParser.Text = "Parse EDI";
			this.Btn_EDIParser.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(12, 129);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(1196, 452);
			this.listBox1.TabIndex = 1;
			// 
			// Txt_Path
			// 
			this.Txt_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Path.Location = new System.Drawing.Point(12, 12);
			this.Txt_Path.Multiline = true;
			this.Txt_Path.Name = "Txt_Path";
			this.Txt_Path.Size = new System.Drawing.Size(1196, 50);
			this.Txt_Path.TabIndex = 2;
			this.Txt_Path.Text = "C:\\Users\\HP\\Desktop\\KMTC.txt";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1220, 591);
			this.Controls.Add(this.Txt_Path);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.Btn_EDIParser);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_EDIParser;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox Txt_Path;
	}
}