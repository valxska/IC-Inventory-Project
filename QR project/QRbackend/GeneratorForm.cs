using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRbackend
{
    public partial class GeneratorForm : Form
        
    {
        private string lastQrText;
        private string codigoQr;
        private bool existNewImage = false;
        int idBorrowPerson;
        public GeneratorForm(int idBorrowPerson)
        {

            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            lastQrText = qrtext.Text;
            picturebox.Image = brcode.Draw(qrtext.Text, 50);
            existNewImage = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu(idBorrowPerson);
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (existNewImage)
                {
                    Bitmap qrImage = (Bitmap)picturebox.Image.Clone();
                    qrImage.Save(@"C:\Users\nsdixonl\Documents\GitHub\IC-Inventory-Project\QR project" + lastQrText + ".png");
                    existNewImage = false;
                }
                else
                {
                    MessageBox.Show("No se ha generado ningun QR nuevo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al guardar el QR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String codigoQr = qrtext.Text;
            AddDeviceForm frm = new AddDeviceForm(codigoQr, idBorrowPerson);
            frm.Show();
            this.Hide();

        }

    }
}
