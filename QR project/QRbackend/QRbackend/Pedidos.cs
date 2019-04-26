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
    public partial class Pedidos : Form
    {
        private bool mode;
        private BD bd;
        private string device;
        private int idBorrowPerson;
        public Pedidos(bool mode, string pdevice, int idBorrowPerson)
        {
            InitializeComponent();
            this.mode = mode;
            this.idBorrowPerson = idBorrowPerson;
            device = pdevice;
            bd = new BD();

            comboType.Items.Add("Interno");   // 0
            comboType.Items.Add("Externo");    // 1

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = String.Empty;
            string name = String.Empty;
            string lastname = String.Empty;
            string phone = String.Empty;
            string email = String.Empty;
            string description = String.Empty;

            if(text_ID.Text != id && text_Name.Text != name && text_LastName.Text != lastname && text_Phone.Text != phone && text_Email.Text != email && text_Description.Text != description)
            {
                int eventtype = mode ? 2 : 1;
                id = text_ID.Text;
                name = text_Name.Text;
                lastname = text_LastName.Text;
                phone = text_Phone.Text;
                email = text_Email.Text;
                description = text_Description.Text;

                int idPerson = bd.VerifyPerson(id, name, lastname, comboType.SelectedIndex +1 , 0, email, phone);
                bd.AddEvent(bd.VerifyDevice(device), idPerson, idBorrowPerson, eventtype, description);
            }

            

            
        }
    }
}
