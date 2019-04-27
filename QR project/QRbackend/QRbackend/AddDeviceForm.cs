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
    public partial class AddDeviceForm : Form
    {
        private int idBorrowPerson;
        public AddDeviceForm(int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void qrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDeviceForm fm = new AddDeviceForm(idBorrowPerson);
            fm.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu(idBorrowPerson);
            fm.Show();
        }
    }
}
