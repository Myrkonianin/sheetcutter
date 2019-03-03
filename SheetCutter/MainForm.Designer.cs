/*
 * SerikOFF created this class in 14.12.2018
 */
namespace SheetCutter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.NumericUpDown xBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown rowCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Button cutButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.cutButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.xBox = new System.Windows.Forms.NumericUpDown();
			this.rowCount = new System.Windows.Forms.NumericUpDown();
			this.fileNameLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(68, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Count sprites in 1 row";
			// 
			// label2
			// 
			this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label2.Location = new System.Drawing.Point(68, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Size of 1 sprite";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(12, 112);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 5;
			this.browseButton.Text = "Browse...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// cutButton
			// 
			this.cutButton.Location = new System.Drawing.Point(93, 112);
			this.cutButton.Name = "cutButton";
			this.cutButton.Size = new System.Drawing.Size(75, 23);
			this.cutButton.TabIndex = 6;
			this.cutButton.Text = "Cut!";
			this.cutButton.UseVisualStyleBackColor = true;
			this.cutButton.Click += new System.EventHandler(this.CutButtonClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "png";
			this.openFileDialog1.FileName = "spritesheet.png";
			this.openFileDialog1.Filter = "PNG files|*.png|Все файлы|*.*";
			// 
			// xBox
			// 
			this.xBox.Location = new System.Drawing.Point(12, 12);
			this.xBox.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.xBox.Name = "xBox";
			this.xBox.Size = new System.Drawing.Size(39, 20);
			this.xBox.TabIndex = 7;
			this.xBox.Value = new decimal(new int[] {
			16,
			0,
			0,
			0});
			// 
			// rowCount
			// 
			this.rowCount.Location = new System.Drawing.Point(12, 38);
			this.rowCount.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.rowCount.Name = "rowCount";
			this.rowCount.Size = new System.Drawing.Size(39, 20);
			this.rowCount.TabIndex = 8;
			this.rowCount.Value = new decimal(new int[] {
			6,
			0,
			0,
			0});
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fileNameLabel.Location = new System.Drawing.Point(12, 75);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(156, 23);
			this.fileNameLabel.TabIndex = 9;
			this.fileNameLabel.Text = "Choose sprite...";
			this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(185, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 121);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 147);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.fileNameLabel);
			this.Controls.Add(this.rowCount);
			this.Controls.Add(this.xBox);
			this.Controls.Add(this.cutButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(334, 185);
			this.MinimumSize = new System.Drawing.Size(334, 185);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "SheetCutter";
			((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
