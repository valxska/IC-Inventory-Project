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
    public partial class DatosDevolucion : Form
    {
        private bool mode;
        private BD bd;
        private string device;
        private int idBorrowPerson;

      
        public DatosDevolucion(int idBorrowPerson)
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector fm = new Lector (false, idBorrowPerson);
            fm.Show();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string id = String.Empty;          
            string email = String.Empty;
            string description = String.Empty;
            if (comboB.Text != id && text_Email.Text != email && text_Description.Text != description);
            {
                int eventtype = mode ? 2 : 1;
                id = comboB.Text;
                email = text_Email.Text;
                description = text_Description.Text;
                
                description = text_Description.Text;
           

                int idPerson = bd.SearchPerson(id);
                bd.AddEvent(bd.VerifyDevice(device), idPerson, idBorrowPerson, eventtype, description);

                MessageBox.Show("Successful transaction");
                this.Hide();
                Menu fm = new Menu(idBorrowPerson);
                fm.Show();
            }
            
            
        }
    }
    
    
}
