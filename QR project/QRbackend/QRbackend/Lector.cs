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
        private int idBorrowPerson;
        Thread analyzerQr;

        public Lector(bool mode, int idBorrowPerson)
        {
            InitializeComponent();
            this.mode = mode;
            this.idBorrowPerson = idBorrowPerson;
            timer1.Start();

        }

        
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu(idBorrowPerson);
            fm.Show();
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
                timer1.Stop();
                finalFrame.Stop();
                this.Hide();
               

                if (mode)
                {
                    Pedidos pedido = new Pedidos(txtQR.Text, idBorrowPerson);   
                    pedido.Show();

                }
                else
                {

                    DatosDevolucion dev = new DatosDevolucion(idBorrowPerson);
                    dev.Show();
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
