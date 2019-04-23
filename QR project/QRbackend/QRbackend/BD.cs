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


        //Falta Probar
        public bool AddDevice(String pQR, String pSerialCode, int pPrice, String pDescription, String pBrandName, String pEstateName, String pCategory)
        {

            this.connection.Open();
            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            AddBrand(pBrandName);  // Prueba: abrir funcion AddBrand para verificar si la marca ya existe o si se debe agregar a la tabla Brand.
            code.Parameters.AddWithValue ("@idBrand", "Select idBrand From brand where brandName = '" + pBrandName + "' ");  //Guarda el idBrand para insertarlo en la tabla Device.

            AddEstate(pEstateName);
            code.Parameters.AddWithValue("@idEstate", "Select idEstate From estate where EstateName = '" + pEstateName + "' ");

           
            code.CommandText = ("Insert Into devices  (QR, serialCode, price, description, idBrand, available, idEstate) Values ('"+ pQR +"' , '"+ pSerialCode +"', '"+ pPrice +"', '"+ pDescription + "', @idBrand, 1, @idEstate ");
            //code.ExecuteNonQuery();

            this.connection.Open();
            this.connection.Close();
            MySqlDataReader rdr = code.ExecuteReader();


            if (rdr.Read())
            {
                this.connection.Open();
                this.connection.Close();
                return true;
            }
            else
            {
                this.connection.Close();
                return false;
            }
        }


        public void AddBrand (String pBrandName)
            {
        
            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            code.CommandText = ("Select idBrand From brand where brandName = '"+ pBrandName +"' ");

            MySqlDataReader rdr = code.ExecuteReader();

         
                if (rdr.Read())
                {
                    this.connection.Close();
                    //return false;   // No se agrega porque ya existe
                }
                else
                {

                    this.connection.Close();
                    this.connection.Open();
                    code.Connection = this.connection;

                    code.CommandText = ("Insert Into brand (brandName) Values ('" + pBrandName + "') ");
                    code.ExecuteReader();
                    this.connection.Close();

                   
                    //return true;  //Se agrega porque no existe

                 }
                
                                
            }


        public void  AddEstate(String pEstateName)
        {
            this.connection.Open();


            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            code.CommandText = ("Select idEstate From estate where EstateName = '" + pEstateName + "' ");

            MySqlDataReader rdr = code.ExecuteReader();


            if (rdr.Read())
            {
                this.connection.Close();
                //return false;
              
            }
            else
            {
                this.connection.Close();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into estate (EstateName) Values ('" + pEstateName + "') ");
                code.ExecuteReader();
                this.connection.Close();

                //return true;

            }

        }

        public bool AddCategory(String pCategoryName)
        {
            this.connection.Open();


            MySqlCommand code = new MySqlCommand();
            code.Connection = this.connection;

            code.CommandText = ("Select idCategory From category where categoryName = '" + pCategoryName + "' ");

            MySqlDataReader rdr = code.ExecuteReader();


            if (rdr.Read())
            {
                this.connection.Close();
                return false;   // No se agrega porque ya existe
            }
            else
            {

                this.connection.Close();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into category (categoryName) Values ('" + pCategoryName + "') ");
                code.ExecuteReader();
                this.connection.Close();


                return true;  //Se agrega porque no existe

            }
        }

            public bool AddPerson(String pId, String pPersonName, String pPersonLastname, String pType, int pAuthorized, int pidUser)
            {
                MySqlCommand code = new MySqlCommand();
                code.Connection = this.connection;

                
                string TipoPersona = ("Select idPersonalType From PersonalType where nombre = '" + pType + "' ");

            //AddUser(pWwid, pPassword); //Añade el usuario a la bd. Recibe la contraseña y el wwid
            //string Usuario = ("Select idUser From user where wwid = '" + pWwid + "' ");


                code.CommandText = ("Select idPerson From person where id = '" + pId + "' ");
                this.connection.Close();
                this.connection.Open();
                MySqlDataReader rdr = code.ExecuteReader();


                if (rdr.Read())
                {
                    this.connection.Close();
                    return true;
                }
                else
                {
                    code.CommandText = ("Insert Into person  (ID, personname, personlastname, idType, availabled, authorized, idUser) Values ('" + pId + "' , '" + pPersonName + "' , '" +  pPersonLastname + "', '" + TipoPersona + "' , '1' , '" + pAuthorized +"', '1' ");
                    this.connection.Close();
                    return false;
                }
            }


            public bool AddUser(String pWwid, String pPassword)
            {
                this.connection.Open();


                MySqlCommand code = new MySqlCommand();
                code.Connection = this.connection;

                code.CommandText = ("Select idUser From user where wwid = '" + pWwid + "' ");

                MySqlDataReader rdr = code.ExecuteReader();


                if (rdr.Read())
                {
                    this.connection.Close();
                    return false;   // No se agrega porque ya existe
                }
                else
                {

                    this.connection.Close();
                    this.connection.Open();
                    code.Connection = this.connection;

                    code.CommandText = ("Insert Into user (wwwid,password) Values ('" + pWwid + "','" + pPassword + "') ");
                    code.ExecuteReader();
                    this.connection.Close();


                    return true;  //Se agrega porque no existe

                }

            }

    }
}
