
namespace Kurs
{
	partial class FormMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.турыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.путешествияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.затратыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.турыToolStripMenuItem,
            this.путешествияToolStripMenuItem,
            this.затратыToolStripMenuItem,
            this.отчетToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// турыToolStripMenuItem
			// 
			this.турыToolStripMenuItem.Name = "турыToolStripMenuItem";
			this.турыToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.турыToolStripMenuItem.Text = "Туры";
			// 
			// путешествияToolStripMenuItem
			// 
			this.путешествияToolStripMenuItem.Name = "путешествияToolStripMenuItem";
			this.путешествияToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.путешествияToolStripMenuItem.Text = "Путешествия";
			// 
			// затратыToolStripMenuItem
			// 
			this.затратыToolStripMenuItem.Name = "затратыToolStripMenuItem";
			this.затратыToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.затратыToolStripMenuItem.Text = "Затраты";
			// 
			// отчетToolStripMenuItem
			// 
			this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
			this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.отчетToolStripMenuItem.Text = "Отчет";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Главная форма";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem путешествияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem затратыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
	}
}