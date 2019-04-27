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
        public Return()
        {
            InitializeComponent();
        }

        private void text_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string id = String.Empty;
            string description = String.Empty;

            if (text_ID.Text != id && Description.Text != description)
            {



            }
        }
    }
}
