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
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using ZXing;
using System.Runtime.Remoting.Channels;
using LMS_BussinessLogic;

namespace Washing_App.Order.Order
{
    public partial class frmOpenCamera : Form
    {

        FilterInfoCollection filterInfoCollection;

        VideoCaptureDevice videoCaptureDevice; 

        public delegate void DataBackEventHandler( object sender, int OrderID); 

        public event DataBackEventHandler DataBack;

        public frmOpenCamera()
        {
            InitializeComponent();
        }

        private void frmOpenCamera_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            videoCaptureDevice.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            BarcodeReader reader = new BarcodeReader();

            var Result = reader.Decode(bitmap);

            if (Result != null)
            {

                txOrderID.Invoke(new MethodInvoker(delegate () { txOrderID.Text = Result.ToString(); }));

            }

            pictureBox1.Image = bitmap;

        }

        private void frmOpenCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        private void btConfrim_Click(object sender, EventArgs e)
        {

            DataBack.Invoke(this, int.Parse(txOrderID.Text));

            this.Close();
        }
    }
}
