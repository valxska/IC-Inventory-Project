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
            BD PruebaDeBD = new BD();
            //bool x = PruebaDeBD.DevicexCategory(2, 1);

            bool x = PruebaDeBD.AddDevice("ABCDE", "HB24I1", 12000, "Esta muy lindo", "Samsung", "Malo", "Electronica");
            //MessageBox.Show(x[0].ToString());

            /*if (x) {

                MessageBox.Show("Funcionó");  //Se insertó
            }
            else
            {
                MessageBox.Show("No funcionó");  // No se insertó porque ya existía
            }*/


        }
    }
}
