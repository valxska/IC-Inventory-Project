using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Funciones respectivas a la BD

namespace QRbackend
{
    class BD
    {
        private MySqlConnection conection = new MySqlConnection("server = localhost; user id = root; password = Poder*16; persistsecurityinfo = True; database = inventario_ic");
        
    }
}
