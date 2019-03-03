/*
 * SerikOFF created this class in 14.12.2018
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SheetCutter
{
	public partial class MainForm : Form{	
		
		#region Values
		public Settings settings;
		private int x;
		private string filePath;
		private bool haveArgs;
		private string fileName;
		#endregion
		
		
		public MainForm(){
			InitializeComponent();
			haveArgs = false;
			settings = new Settings();
			string[] args = Environment.GetCommandLineArgs();
			filePath = "";
			if(args.Length > 1){
				filePath = args[1];
				haveArgs = true;
			}
			if(!Directory.Exists("out\\")){
				Directory.CreateDirectory("out\\");
			}
		}
		
		
		void BrowseButtonClick(object sender, EventArgs e){
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				Bitmap pezda = new Bitmap(openFileDialog1.FileName);
				x = int.Parse(xBox.Value.ToString());
				
				if(!haveArgs){
					fileNameLabel.Text = settings.lastName(openFileDialog1.FileName);
					fileName = settings.lastName(openFileDialog1.FileName);
				}else{
					fileNameLabel.Text = settings.lastName(filePath);
					fileName = settings.lastName(filePath);
				}
				
				pictureBox1.Image = pezda;
				pezda.SetResolution((float)pictureBox1.Width, (float)pictureBox1.Size.Height);
			}
		}
		
		void CutButtonClick(object sender, EventArgs e){
			Bitmap bmp;
			
			
			
			if(haveArgs)
				bmp = new Bitmap(filePath);
			else
				bmp = new Bitmap(openFileDialog1.FileName);
			
			string workingDirectory = "out\\"+fileName+"\\";
			
			if(File.Exists(workingDirectory+"*.*")){
			 	File.Delete("*.*");
			}
			               
			if(!Directory.Exists(workingDirectory))
				Directory.CreateDirectory(workingDirectory);
			
			int y = bmp.Size.Height / int.Parse(xBox.Value.ToString());
			for (int i = 0; i < y; i++) {
				for (int c = 0;c < int.Parse(rowCount.Value.ToString()); c++) {
					RectangleF cloneRect = cloneRect = new RectangleF(x*c, x*i, x, x);

					System.Drawing.Imaging.PixelFormat format = bmp.PixelFormat;
		    		Bitmap cloneBitmap = bmp.Clone(cloneRect, format);
		    		cloneBitmap.Save(workingDirectory+"kotokopterImage-"+i+"-"+c+".png", System.Drawing.Imaging.ImageFormat.Png);
				}
			}
		}
		
		
	}
}
