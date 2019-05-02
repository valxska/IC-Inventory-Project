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
    public partial class ViewData : Form
    {
        private int idBorrowPerson;
        private BD bd;

        public ViewData(int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
            bd = new BD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridData.DataSource = bd.GetInfoInventory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridData.DataSource = bd.GetInfoPerson();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu(idBorrowPerson);
            fm.Show();
        }

        private void ViewData_Load(object sender, EventArgs e)
        {

        }
    }
}
