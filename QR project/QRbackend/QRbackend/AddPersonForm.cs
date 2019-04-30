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
        public AddPersonForm()
        {
            InitializeComponent();

            typebox.Items.Add("Interno");   // 1
            typebox.Items.Add("Externo");    // 2
            typebox.Items.Add("Administrador");    // 3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            String nombre = namebox.Text;
            String tipo = typebox.SelectedItem.ToString();
            String apellido = lastnamebox.Text;
            String telefono = phonebox.Text;
            String email = emailbox.Text;
            String id = idbox.Text;
            int allowed;
            if(tipo == "Interno")
            {
                tipo = "Interno";
                allowed = 0;
            }if (tipo == "Externo")
            {
                tipo = "Externo";
                allowed = 0;
            }
            else
            {
                tipo = "Administrador";
                allowed = 1;
            }


        }
    }
}
