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
    public partial class AddPersonForm : Form
    {
        private BD bd;
        public AddPersonForm()
        {
            InitializeComponent();
            bd = new BD();

            typebox.Items.Add("Interno");   // 1
            typebox.Items.Add("Externo");    // 2
            typebox.Items.Add("Admin");    // 3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            String nombre = namebox.Text;
            int tipo = typebox.SelectedIndex;
            String apellido = lastnamebox.Text;
            String email = emailbox.Text;
            String id = idbox.Text;
            String phone = phonebox.Text;
            int allowed=0;

            if (tipo == 2)
            {
                allowed = 1;
            }

            bd.AddPerson(id,nombre,apellido,tipo,allowed,email, phone);


        }
    }
}
