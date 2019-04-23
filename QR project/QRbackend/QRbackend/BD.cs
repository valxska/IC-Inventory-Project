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
        private MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = Poder*16; persistsecurityinfo = True; database = inventario_ic");
     
     public bool LogIn (String pWWID, String pPassword)
     {
            this.connection.Open();


            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            code.CommandText = ("Select * from user Where WWID = '" + pWWID + "' and password = '" + pPassword + "' ");

            MySqlDataReader rdr = code.ExecuteReader();
         

            if (rdr.Read())
            {
                this.connection.Close();
                return true;
            }
            else
            {
                this.connection.Close();
                return false;
            }

            


        }
        //Terminar
        public void AddDevice(String pQR, String pSerialCode, String pPrice, String pDescription, String PBrand, String pEstate, String pCategory)
        {
            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            //code.CommandText = ("Insert Into devices  (QR, serialCode, price, description, idBrand, available, idEstate) Values ('"+ pQR +"' , '"+ pSerialCode +"', "+ pPrice +", '"+ pDescription +"', "+ idBrand+", 1 , "+ idEstate);

            MySqlDataReader rdr = code.ExecuteReader();


            if (rdr.Read())
            {
                this.connection.Close();
                //return true;
            }
            else
            {
                this.connection.Close();
                //return false;
            }
        }

        public bool AddBrand(String pBrandName)
            {
            this.connection.Open();


            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            code.CommandText = ("Select idBrand From brand where brandName = '"+ pBrandName +"' ");

            MySqlDataReader rdr = code.ExecuteReader();


            if (rdr.Read())
            {
                this.connection.Close();
                return false;
            }
            else
            {
                this.connection.Close();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into brand (brandName) Values ('" + pBrandName + "') ");
                code.ExecuteReader();
                this.connection.Close();

                return true;
                
            }

        }

        public bool AddEstate(String pEstateName)
        {
            this.connection.Open();


            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            code.CommandText = ("Select idEstate From estate where EstateName = '" + pEstateName + "' ");

            MySqlDataReader rdr = code.ExecuteReader();


            if (rdr.Read())
            {
                this.connection.Close();
                return false;
            }
            else
            {
                this.connection.Close();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into estate (EstateName) Values ('" + pEstateName + "') ");
                code.ExecuteReader();
                this.connection.Close();

                return true;

            }

        }

    }
}
