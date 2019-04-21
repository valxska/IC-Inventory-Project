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

namespace WindowsFormsApplication1
{
    public partial class Fm_Lector : Form
    {
        FilterInfoCollection deviceCapture;
        VideoCaptureDevice finalFrame;
        Bitmap last_map;
        String data = String.Empty;
        bool frame_exist = false;
        public Fm_Lector()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void Iniciar() {

            finalFrame = new VideoCaptureDevice(deviceCapture[devices_box.SelectedIndex].MonikerString);
            finalFrame.Start();
            finalFrame.NewFrame += finalFrame_renew;
            Thread analyzerQr = new Thread(new ThreadStart(analyze_qr));
            analyzerQr.Start();
            
        }

        private void finalFrame_renew(object sender, NewFrameEventArgs eventArgs) {
            last_map = (Bitmap)eventArgs.Frame.Clone();
            picture_cam.Image = last_map;
            frame_exist = true;
        }


        private void analyze_qr() {
            string texto = null;
            //textBox.Text = "Hola";
            while (texto == null) {
                BarcodeReader br = new BarcodeReader();
                try
                {
                    texto = br.Decode((Bitmap)picture_cam.Image.Clone()).ToString();
                    //textBox.Text = texto;
                    data = texto;
                    MessageBox.Show(texto, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    analyze_qr();
                }
                catch {
                    //MessageBox.Show("No se ha generado ningun QR nuevo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Thread.Sleep(100);
            }
        }


        private void Fm_Lector_Load(object sender, EventArgs e)
        {
            deviceCapture = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo cam in deviceCapture){
                devices_box.Items.Add(cam.Name);
            }
            devices_box.SelectedIndex = 0;
            finalFrame = new VideoCaptureDevice();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            txtQR.Text = "asdsasa";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtQR.Text = data;
        }
    }
}
