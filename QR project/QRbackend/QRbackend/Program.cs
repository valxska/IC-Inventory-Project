using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRbackend
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            BD PruebaDeLogIn = new BD();
            bool x = PruebaDeLogIn.AddBrand("Alienware");
            if (x) {

                MessageBox.Show("Funcionó");
            }
            else
            {
                MessageBox.Show("No funcionó");
            }
           

        }
    }
}
