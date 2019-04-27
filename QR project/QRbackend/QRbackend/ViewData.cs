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
    public partial class ViewData : Form
    {
        private int idBorrowPerson;
        public ViewData(int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
