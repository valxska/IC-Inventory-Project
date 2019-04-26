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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector lector = new Lector(false);
            lector.Show();
        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector lector = new Lector(true);
            lector.Show();
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewData data = new ViewData();
            data.Show();
        }
    }
}
