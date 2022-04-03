
namespace Kurs
{
	partial class FormTours
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
			this.ButtonRef = new System.Windows.Forms.Button();
			this.ButtonDel = new System.Windows.Forms.Button();
			this.ButtonUpd = new System.Windows.Forms.Button();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonRef
			// 
			this.ButtonRef.Location = new System.Drawing.Point(356, 252);
			this.ButtonRef.Name = "ButtonRef";
			this.ButtonRef.Size = new System.Drawing.Size(85, 31);
			this.ButtonRef.TabIndex = 15;
			this.ButtonRef.Text = "Обновить";
			this.ButtonRef.UseVisualStyleBackColor = true;
			// 
			// ButtonDel
			// 
			this.ButtonDel.Location = new System.Drawing.Point(356, 199);
			this.ButtonDel.Name = "ButtonDel";
			this.ButtonDel.Size = new System.Drawing.Size(85, 31);
			this.ButtonDel.TabIndex = 14;
			this.ButtonDel.Text = "Удалить";
			this.ButtonDel.UseVisualStyleBackColor = true;
			// 
			// ButtonUpd
			// 
			this.ButtonUpd.Location = new System.Drawing.Point(356, 148);
			this.ButtonUpd.Name = "ButtonUpd";
			this.ButtonUpd.Size = new System.Drawing.Size(85, 31);
			this.ButtonUpd.TabIndex = 13;
			this.ButtonUpd.Text = "Изменить";
			this.ButtonUpd.UseVisualStyleBackColor = true;
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Location = new System.Drawing.Point(356, 99);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(85, 31);
			this.ButtonAdd.TabIndex = 12;
			this.ButtonAdd.Text = "Добавить";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.ColumnHeadersVisible = false;
			this.dataGridView.Location = new System.Drawing.Point(26, 39);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(286, 322);
			this.dataGridView.TabIndex = 11;
			// 
			// FormTours
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 413);
			this.Controls.Add(this.ButtonRef);
			this.Controls.Add(this.ButtonDel);
			this.Controls.Add(this.ButtonUpd);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.dataGridView);
			this.Name = "FormTours";
			this.Text = "Туры";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ButtonRef;
		private System.Windows.Forms.Button ButtonDel;
		private System.Windows.Forms.Button ButtonUpd;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}