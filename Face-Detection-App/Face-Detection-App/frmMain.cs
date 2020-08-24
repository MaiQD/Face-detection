using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Face_Detection_App
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		FilterInfoCollection filter;
		VideoCaptureDevice device;
		
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			foreach (FilterInfo dev in filter)
				cbxDevice.Items.Add(dev.Name);
			if (cbxDevice.Items.Count>0)
				cbxDevice.SelectedIndex = 0;
			else
				btnDetect.Enabled = false;
			device = new VideoCaptureDevice();
		}

		private void btnDetect_Click(object sender, EventArgs e)
		{
			device = new VideoCaptureDevice(filter[cbxDevice.SelectedIndex].MonikerString);
			device.NewFrame += Device_NewFrame;
			device.Start();
		}
		static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("Training Data/haarcascade_frontalface_default.xml");
		private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			//ảnh gốc
			Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
			Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);

			Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
			foreach (var rectangle in rectangles)
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					using (Pen pen = new Pen(Color.Red,1))
					{
						graphics.DrawRectangle(pen, rectangle);
					}
				}
			}
			picBox.Image = bitmap;
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (device.IsRunning)
				device.Stop();
		}
	}
}
