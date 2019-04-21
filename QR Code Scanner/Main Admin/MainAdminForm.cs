using Qr_Code_Generator;
using QR_Code_Scanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Admin
{
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScannerForm frm = new ScannerForm();
            frm.Show();
            this.Hide();
        }

        private void generarQrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratorForm frm = new GeneratorForm();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
