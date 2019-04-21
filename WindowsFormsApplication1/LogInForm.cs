using Main_Admin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Admin
{

  

    public partial class LogInForm : Form
    {
       

        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connStr = "server=localhost;user id=root;persistsecurityinfo=True;database=inventario_ic";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string val1 = textBox1.Text;

            string sql = "Select WWID From User Where WWID=@pwwid";
            sql.Parameters.AddWithValue("@pwwid", val1);

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
