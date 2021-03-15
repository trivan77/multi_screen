using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Multi_Screen
{
     public partial class MainScreen : Form
     {
          public MainScreen()
          {
               InitializeComponent();
          }

          FilterInfoCollection filterInfoCollection;
          VideoCaptureDevice videoCaptureDevice;
          
          private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
          {
               pbWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
          }

          private void btnWatch_2_Click(object sender, EventArgs e)
          {
               BigScreen bg = new BigScreen();


               bg.StartPosition = FormStartPosition.Manual;

               bg.Bounds = Screen.AllScreens[1].Bounds;
               bg.Show();
          }

          private void MainScreen_Load(object sender, EventArgs e)
          {
               videoCaptureDevice = new VideoCaptureDevice();

               //videoCaptureDevice = new VideoCaptureDevice();

               //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);


               //videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
               //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
               //videoCaptureDevice.Start();
          }

          private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
          {
               if(videoCaptureDevice.IsRunning == true)
               {
                    videoCaptureDevice.Stop();
               }
          }
     }
}
