﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;



//Funciones respectivas a la BD

namespace QRbackend
{
    class BD
    {
        private MySqlConnection connection = new MySqlConnection("Database = inventario_ic; Data Source = localhost; User Id = root; Password=Poder*16");


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



        public int VerifyDevice(string pQR)
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
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    return -1;

                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList[0];


        }

        public bool AddDevice(String pQR, String pSerialCode, float pPrice, String pDescription, String pBrandName, String pEstateName, String pCategory)   //
        {
            try
            {
                MySqlCommand code = new MySqlCommand();

                int idDevice = VerifyDevice(pQR);
                int idCategory = VerifyCategory(pCategory);

            if (idDevice == -1)
            {


                int idBrand = VerifyBrand(pBrandName);
                int idEstate = VerifyEstate(pEstateName);

                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into devices  (QR, serialCode, price, description, idBrand, available, idEstado) Values ('" + pQR + "' , '" + pSerialCode + "', " + pPrice + ", '" + pDescription + "', " + idBrand + ", 1, " + idEstate + ")");

                MySqlDataReader rdr = code.ExecuteReader();
                this.connection.Close();

            }
                idDevice = VerifyDevice(pQR);
                DevicexCategory(idDevice, idCategory);

                return true;
            }
            catch (Exception e)
            {
                this.connection.Close();

            }
            return false;

        }

        public bool DevicexCategory(int pIdDevice, int pIdCategory)
        {
            try
            {
                this.connection.Open();
                MySqlCommand code = new MySqlCommand();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into devicesxcategory (idDevices, idCategory) Values (" + pIdDevice + "," + pIdCategory + ")");

                MySqlDataReader rdr = code.ExecuteReader();
                return true;

            }

            finally
            {
                this.connection.Close();

            }
            return false;


        }



        public int VerifyBrand(String pBrandName)
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
            return rowList[0];


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


        public int VerifyEstate(String pEstateName)
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
            return rowList[0];


        }

        
        public int VerifyCategory(String pCategoryName)
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
            return rowList[0];


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

                code.CommandText = ("Insert Into eventtype (name) Values ('" + pEventType + "') ");
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


        public int VerifyPerson(string pID, String pName, String pLastName, int pType, int pAuthorized, String pEmail, String pPhone)
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

                    return 0;

                }

            }
            finally
            {
                this.connection.Close();
            }
            

            return rowList[0];

        }


        public String AddPerson(String pID, String pName, String pLastName, int pType, int pAuthorized, String pEmail, String pPhone)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into person (ID, personName, personLastName, idType, available, authorized) Values ('" + pID + "', '" + pName + "', '" + pLastName + "', " + pType + ", 1, " + pAuthorized + ") ");
                code.ExecuteReader();
                this.connection.Close();

                

                return pID;
            }

            finally
            {
                this.connection.Close();
            }
            return "";
            
        }



        public int VerifyEmail(String pEmail, int pIdPerson)
        {
            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idEmail From email where email = '" + pEmail + "' and idPerson ="+pIdPerson);

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
            return rowList[0];
        }


        public bool AddEmail(string pEmail, int pIdPerson)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into email (email, idPerson) Values ('" + pEmail + "', " + pIdPerson + ") ");
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


        public int VerifyPhone(String pPhone, int pIdPerson)
        {
            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idPhone From phone where phone = '" + pPhone + "' and idPerson = "+pIdPerson);

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
            return rowList[0];

        }

        public bool AddPhone(String pPhone, int pIdPerson)
        {
            try
            {
                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into phone(phone, idPerson) Values('" + pPhone + "', " + pIdPerson + ") ");
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

        public bool AddEvent (int pIdDevice, int pIdPerson, int pBorrowIdPerson, int pIdType, String pDescription)
        {
            try {
                this.connection.Open();
                MySqlCommand code = new MySqlCommand();
                code.Connection = this.connection;
                DateTime momento = DateTime.Now;


                code.CommandText = ("Insert Into event (creationDate, description,idEventType) Values ('" + momento.ToString("yyyy-MM-dd H:mm:ss") + "', '" + pDescription + "','" + pIdType + "')  ");
                code.ExecuteReader();
                this.connection.Close();

                int idEvent = GetEvent(momento);
                AddHistory(idEvent, pIdDevice, pIdPerson, pBorrowIdPerson);

                return true;
            }
            finally{
                this.connection.Close();
            }

            return false;
        }


        public int GetEvent(DateTime pCreationDate) {
            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idEvent From event where creationDate = '" + pCreationDate.ToString("yyyy-MM-dd H:mm:ss") +"' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                
                    this.connection.Close();
                    return rowList[0];
                
            }
            finally
            {
                this.connection.Close();
            }
            return -1;
                        
        }

        public bool AddHistory(int pIdEvent, int pIdDevice, int pIdPerson, int pBorrowIdPerson)
        {
            try { 
                this.connection.Open();
            
                MySqlCommand code = new MySqlCommand();
                code.Connection = this.connection;

                code.CommandText = ("Insert Into history (idEvent,idDevices, idPerson, BorrowIdPerson) Values (" + pIdEvent + "," + pIdDevice + ", "+ pIdPerson+", "+pBorrowIdPerson+") ");
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

        public DataTable GetInfoPerson()
        {
            try
            {
                this.connection.Open();
                               
                string command = "select ID, personName, personLastName, available, authorized from person";
                MySqlDataAdapter adp = new MySqlDataAdapter(command, this.connection );
                DataTable info = new DataTable();
                adp.Fill(info);
                this.connection.Close();
                return info;

            }

            finally
            {
                this.connection.Close();

            }
            return null;

        }

        public DataTable GetInfoInventory()
        {
            try
            {
                this.connection.Open();

                string command = "select QR, serialCode, price, description, idBrand, available, idEstado from devices";
                MySqlDataAdapter adp = new MySqlDataAdapter(command, this.connection);
                DataTable info = new DataTable();
                adp.Fill(info);
                this.connection.Close();
                return info;

            }

            finally
            {
                this.connection.Close();

            }
            return null;

        }

        public List<string> PersonID()
        {
            List<string> rowList = new List<string>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();
                code.Connection = this.connection;

                code.CommandText = ("Select ID From person");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetString(0));

                }

                this.connection.Close();

            }
            finally
            {
                this.connection.Close();
            }
            return rowList;

        }
        public int VerifyType(String pType)
        {

            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select idType From typd where idtype = '" + pType + "' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    return -1;

                }

            }
            finally
            {
                this.connection.Close();
            }
            return rowList[0];


        }

        

        public int SearchPerson(String pID) {

            List<int> rowList = new List<int>();
            try
            {

                MySqlCommand code = new MySqlCommand();
                this.connection.Open();

                code.Connection = this.connection;

                code.CommandText = ("Select IdPerson from person where ID = '"+ pID +"' ");

                MySqlDataReader rdr = code.ExecuteReader();

                while (rdr.Read())
                {
                    rowList.Add(rdr.GetInt32(0));

                }
                if (rowList.Count == 0)
                {
                    this.connection.Close();
                    return -1;

                }
            }

            finally
            {
                this.connection.Close();
            }
            return rowList[0];



        }


               

    }
}
