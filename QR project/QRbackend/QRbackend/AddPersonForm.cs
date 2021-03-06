﻿using System;
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
        private int idBorrowPerson;

        public AddPersonForm(int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;

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
            tipo = tipo +1;
            String apellido = lastnamebox.Text;
            String email = emailbox.Text;
            String id = idbox.Text;
            String phone = phonebox.Text;
            int allowed=0;

            if (tipo == 2)
            {
                allowed = 1;
            }

            bd.VerifyPerson(id,nombre,apellido,tipo,allowed,email, phone);

            int id1 = bd.SearchPerson(id);
            bd.VerifyEmail(email, id1);
            bd.VerifyPhone(phone, id1);

            MessageBox.Show("Successful transaction");
            this.Hide();
            Menu fm = new Menu(idBorrowPerson);
            fm.Show();


        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu(idBorrowPerson);
            fm.Show();
        }
    }
}
