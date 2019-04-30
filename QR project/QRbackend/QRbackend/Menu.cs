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
        private int idBorrowPerson;
        public Menu(int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector lector = new Lector(false, idBorrowPerson);
            lector.Show();
        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector lector = new Lector(true, idBorrowPerson);
            lector.Show();
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewData data = new ViewData(idBorrowPerson);
            data.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDeviceForm fm = new AddDeviceForm(null,idBorrowPerson);
            fm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
