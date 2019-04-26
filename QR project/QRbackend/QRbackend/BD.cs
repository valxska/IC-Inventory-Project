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

        public int LogIn(String pWWID, String pPassword)
        {

            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idPerson from user Where WWID = '" + pWWID + "' and password = '" + pPassword + "'");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));
                }

            }
            finally
            {
                this.connection.Close();
            }

            if (rowList.Count > 0)
            {
                 return rowList[0];

            }
            else
            {
                return -1;
            }
                                              
        }

        

        public List<int> VerifyDevice(string pQR)
        {

            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idDevices From devices where QR = '" + pQR + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                
            }
            finally
            {
                this.connection.Close();
            }
            return rowList;


        }

        public bool AddDevice(String pQR, String pSerialCode, float pPrice, String pDescription, String pBrandName, String pEstateName, String pCategory)   //
        {
            try
            {               
                MySqlCommand code = new MySqlCommand();
                
                List<int> device = VerifyDevice(pQR);
                int idCategory = VerifyCategory(pCategory)[0];

                if (device.Count == 0)
                {
                    int idBrand = VerifyBrand(pBrandName)[0];
                    int idEstate = VerifyEstate(pEstateName)[0];
                    
                    this.connection.Open();
                    code.Connection = this.connection;

                    code.CommandText = ("Insert Into devices  (QR, serialCode, price, description, idBrand, available, idEstado) Values ('" + pQR + "' , '" + pSerialCode + "', " + pPrice + ", '" + pDescription + "', " + idBrand + ", 1, " + idEstate +")");
                   
                    MySqlDataReader rdr = code.ExecuteReader();
                    this.connection.Close();
                    
                }

                int idDevice = VerifyDevice(pQR)[0];
                DevicexCategory(idDevice, idCategory);

                return true;
            }
            catch(Exception e)
            {
                this.connection.Close();

            }
            return false;

        }

        public bool DevicexCategory (int pIdDevice, int pIdCategory)
        {
            try
            {
                this.connection.Open();
                MySqlCommand code = new MySqlCommand();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into devicesxcategory (idDevices, idCategory) Values ("+pIdDevice+","+pIdCategory+")");

                MySqlDataReader rdr = code.ExecuteReader();
                return true;

            }

            finally
            {
                this.connection.Close();

            }
            return false;


        }



        public List<int> VerifyBrand(String pBrandName)
        {
            List<int> rowList = new List<int>();
            try
            {
                
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idBrand From brand where brandName = '" + pBrandName + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));
                    
                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    AddBrand(pBrandName);                    
                    return VerifyBrand(pBrandName);
                
                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList;
            

        }


        public bool AddBrand(string pBrandName)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into brand (brandName) Values ('" + pBrandName + "') ");
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }

        public bool AddEstate(string pEstateName)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into estate (EstateName) Values ('" + pEstateName + "')");
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }


        public List<int> VerifyEstate(String pEstateName)
        {

            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idEstate From estate where EstateName = '" + pEstateName + "'");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    AddEstate(pEstateName);
                    return VerifyEstate(pEstateName);

                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList;
                                    

        }

        //AÑADIR Categorias para ser relacionadas con un device
        //Recibe el nombre de la categoria
        //Realizado por: Nakisha Dixon el 4/23/19
        //Modificado el 25/04/19
        //falta probar
        public List<int> VerifyCategory(String pCategoryName)
        {
            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idCategory From category where categoryName = '" + pCategoryName + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    AddCategory(pCategoryName);
                    return VerifyCategory(pCategoryName);

                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList;


        }

      
        public bool AddCategory(string pCategoryName)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into category (categoryName) Values ('" + pCategoryName + "') ");
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }

        public bool AddEventType(string pEventType)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into eventtype (name) Values ('" + pEventType +"') ");
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }


        public List<int> VerifyPerson(string pID, String pName, String pLastName, int pType, int pAuthorized, String pEmail, String pPhone)
        {

            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idPerson From person where ID = '" + pID + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));
                }

                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    AddPerson(pID, pName, pLastName, pType, pAuthorized, pEmail, pPhone);
                    return VerifyPerson(pID, pName, pLastName, pType, pAuthorized, pEmail, pPhone);

                }

            }
            finally
            {
                this.connection.Close();
            }
            AddPhone(pPhone, rowList[0]);
            AddEmail(pEmail, rowList[0]);

            return rowList;
            
        }


        public bool AddPerson(String pID, String pName, String pLastName, int pType, int pAuthorized, String pEmail, String pPhone)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into person (ID, personName, personLastName, idType, available, authorized) Values ('" + pID + "', '"+ pName +"', '"+ pLastName +"', "+pType+", 1, "+ pAuthorized +") ");     
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;


        }



        public List<int> VerifyEmail(String pEmail, int pIdPerson)
        {
            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idEmail From email where email = '" + pEmail + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    AddEmail(pEmail, pIdPerson);
                    return VerifyEmail(pEmail, pIdPerson);

                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList;


        }

     
        public bool AddEmail(string pEmail, int pIdPerson)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into email (email, idPerson) Values ('" + pEmail + "', "+pIdPerson+") ");
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }


        public List<int> VerifyPhone(String pPhone, int pIdPerson)
        {
            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idPhone From phone where phone = '" + pPhone + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    AddPhone(pPhone, pIdPerson);
                    return VerifyPhone(pPhone, pIdPerson);

                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList;

        }

        public bool AddPhone(String pPhone, int pIdPerson)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into phone(phone, idPerson) Values('" + pPhone + "', "+pIdPerson+") ");
                code.ExecuteReader();
                this.connection.Close();
                return true;
            }
            finally
            {
                this.connection.Close();
            }
            return false;

      

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
