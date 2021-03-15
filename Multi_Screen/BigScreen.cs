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
     public partial class BigScreen : Form
     {
          public BigScreen()
          {
               InitializeComponent();
          }

          FilterInfoCollection filterInfoCollection;
          VideoCaptureDevice videoCaptureDevice;

          private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
          {
               pbWebCam.Image = (Bitmap)eventArgs.Frame.Clone();
          }

          private void BigScreen_Load(object sender, EventArgs e)
          {
               videoCaptureDevice = new VideoCaptureDevice();

               filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);


               videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
               videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
               videoCaptureDevice.Start();
          }
     }
}
