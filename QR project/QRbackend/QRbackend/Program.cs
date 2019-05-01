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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());

            


            //BD PruebaDeBD = new BD();
            //int x = PruebaDeBD.SearchPerson("878");
            //MessageBox.Show(x.ToString());



            //int x = PruebaDeBD.VerifyBrand("Samsung");
            /*
                        //bool x = PruebaDeBD.AddEvent(1, 2, 2, 1, "Rawayana");
                        MessageBox.Show(x.ToString());
                        //bool x = PruebaDeBD.AddDevice("ABCDh", "HB24I1", 12000, "Esta muy lindo", "Samsung", "Malo", "Electronica");

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
