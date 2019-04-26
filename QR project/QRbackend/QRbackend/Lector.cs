using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Threading;

namespace QRbackend
{
    public partial class Lector : Form
    {
        private FilterInfoCollection deviceCapture;
        private VideoCaptureDevice finalFrame;
        private Bitmap last_map;
        private String data = String.Empty;
        private bool mode;
        private bool exist_qr;
        Thread analyzerQr;

        public Lector(bool mode)
        {
            InitializeComponent();
            this.mode = mode;
            timer1.Start();
        }

        
        private void btn_regresar_Click(object sender, EventArgs e)
        {

        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            finalFrame = new VideoCaptureDevice(deviceCapture[devices_box.SelectedIndex].MonikerString);
            finalFrame.Start();
            finalFrame.NewFrame += finalFrame_renew;
            analyzerQr = new Thread(new ThreadStart(analyze_qr));
            analyzerQr.Start();
        }

        private void finalFrame_renew(object sender, NewFrameEventArgs eventArgs)
        {
            last_map = (Bitmap)eventArgs.Frame.Clone();
            picture_cam.Image = last_map;
        }

        private void analyze_qr()
        {
            string texto = null;

            while (texto == null)
            {
                BarcodeReader br = new BarcodeReader();
                try
                {
                    texto = br.Decode((Bitmap)picture_cam.Image.Clone()).ToString();

                    data = texto;
                    exist_qr = true;
                    MessageBox.Show(texto, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    analyze_qr();
                }
                catch
                {
                }
                Thread.Sleep(100);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtQR.Text = data;
            if (txtQR.Text != String.Empty) {
                if (mode && exist_qr)
                {
                    timer1.Stop();
                    this.Hide();
                    DatosDevolucion devo = new DatosDevolucion();
                    devo.Show();
                }
                else {
                    timer1.Stop();
                    this.Hide();
                    DatosPrestamo prestamo = new DatosPrestamo();
                    prestamo.Show();
                }
            }
        }

        private void Lector_Load(object sender, EventArgs e)
        {
            deviceCapture = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo cam in deviceCapture)
            {
                devices_box.Items.Add(cam.Name);
            }
            devices_box.SelectedIndex = 0;
            finalFrame = new VideoCaptureDevice();
        }
    }
}
