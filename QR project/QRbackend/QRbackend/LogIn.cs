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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pass = String.Empty;
            string wwid = String.Empty;

            if(textWWID.Text != wwid && textPass.Text != pass)
            {
                wwid = textWWID.Text;
                pass = textPass.Text;
                BD bd = new BD();
                if(bd.LogIn( wwid, pass)!= -1){
                    this.Hide();
                    Menu fm = new Menu();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("WWID or password incorrect");

                }

            }
            

        }
    }
}
