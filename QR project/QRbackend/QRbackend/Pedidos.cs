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
        private BD bd;
        private string device;
        private int idBorrowPerson;

        public Pedidos(string pdevice, int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
            device = pdevice;
            bd = new BD();

            comboBoxID.DataSource = bd.PersonID();

            comboType.Items.Add("Interno");   // 0
            comboType.Items.Add("Externo");    // 1
            comboType.Items.Add("Admin");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = String.Empty;
            string name = String.Empty;
            string lastname = String.Empty;
            string phone = String.Empty;
            string email = String.Empty;
            string description = String.Empty;
            string type = String.Empty;

            if (comboBoxID.Text == id || text_Name.Text == name || text_LastName.Text == lastname || text_Phone.Text == phone || text_Email.Text == email || text_Description.Text == description || comboType.Text == type) 
            {
                MessageBox.Show("Complete the information");

            }

            else{
                int eventtype = 1;
                id = comboBoxID.Text;
                name = text_Name.Text;
                lastname = text_LastName.Text;
                phone = text_Phone.Text;
                email = text_Email.Text;
                description = text_Description.Text;           
                int allowed = 0;
                int tipo = comboType.SelectedIndex;

                if (tipo == 2) {
                    allowed = 1;
                }


                int idPerson = bd.VerifyPerson(id, name, lastname, tipo + 1, allowed, email, phone);
                //int idPerson = bd.SearchPerson(id);
                bd.AddEvent(bd.VerifyDevice(device), idPerson, idBorrowPerson, eventtype, description);


                MessageBox.Show("Successful transaction");
                this.Hide();
                Menu fm = new Menu(idBorrowPerson);
                fm.Show();
            }
            
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector lector = new Lector(true,idBorrowPerson);
            lector.Show();
        }
    }
}
