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
        private bool existNewImage = false;
        public GeneratorForm()
        {

            InitializeComponent();
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
            AddDeviceForm frm = new AddDeviceForm(0);
            frm.Show();
            this.Hide();
            this.Hide();

        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
