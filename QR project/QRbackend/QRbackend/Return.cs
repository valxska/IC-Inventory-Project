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
    public partial class Return : Form
    {

        private int idBorrowPerson;
        private BD bd;
        
        public Return(int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
            bd = new BD();
        }

        private void text_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e) // Falta terminar
        {
            string id = String.Empty;
            string description = String.Empty;

            if (text_ID.Text != id && Description.Text != description)
            {
                id = text_ID.Text;
                description = Description.Text;

                this.Hide();
                Menu fm = new Menu(idBorrowPerson);
                fm.Show();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu(idBorrowPerson);
            fm.Show();
        }
    }
}
