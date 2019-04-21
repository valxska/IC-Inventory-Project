using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_Code_Generator
{
    public partial class GeneratorForm : Form
    {
        private string lastQrText;
        private bool existNewImage = false;
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            lastQrText = txtQr.Text;
            imgQr.Image = brcode.Draw(txtQr.Text, 50);
            existNewImage = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratorForm frm = new GeneratorForm();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (existNewImage)
                {
                    Bitmap qrImage = (Bitmap)imgQr.Image.Clone();
                    qrImage.Save(@"C:\Users\jgrubioe\Desktop\QR_Project\IC-INVENTOARIO\QR Code Scanner\QR_images\" + lastQrText + ".png");
                    existNewImage = false;
                }
                else {
                    MessageBox.Show("No se ha generado ningun QR nuevo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch {
                MessageBox.Show("Ha ocurrido un error al guardar el QR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
