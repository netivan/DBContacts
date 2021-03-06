﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBContactLibrary
{
    


    public class Contact
    {
        public int ID;
        public string SSN;
        public string Firstname;
        public string Lastname;
        public override string ToString()
        {
            return $" {ID} -> {SSN} -> {Firstname} -> {Lastname}";
        }

    }



    public class ContactInfo
    {
        public int ID;
        public string info;
        public int? ContactID;
        public override string ToString()
        {
            return $"{ID} -> {info} -> {ContactID}";
        }
    }
    public static class SQLService
    {  
        public static SqlConnection ÖppnaAnslutning()
        {
            SqlConnection DBCo = new SqlConnection();
           DBCo.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBContacts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return DBCo;
        }
        public static Contact ReadContact(int Id)   // id in parameter
        {
            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            var DBCo = ÖppnaAnslutning();

            
            DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand comand = new SqlCommand();     // skapar sql 'comand' 
            comand.CommandText = "ReadContact";    // CommandText är lika med 'select'ect
            comand.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure
            SqlParameter parameter = new SqlParameter("@ID", Id); // definierar in parameter av lagrad proceduren
            parameter.SqlDbType = System.Data.SqlDbType.Int;
            comand.Parameters.Add(parameter);  // lägger parametern till i comand
            comand.Connection = DBCo;  // överför comand till databasen
            SqlDataReader result = comand.ExecuteReader();  // executes och resultaten hamnar il 'result'
            Contact co = new Contact();
            //   while (result.Read())
            if (result.Read())        //  Read() så länge finns rader är den true dvs det tittar om det finns rader. if(result.Read()) = Om det inte finns nån rad är den false  
            {
                co.ID = (int)result[0];
                co.SSN = result[1].ToString();
                co.Firstname = result[2].ToString();
                co.Lastname = result[3].ToString();

            }

            return co;

        }


        public static List<Contact> ReadAllContact()
        {
            List<Contact> LiCo = new List<Contact>();

            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            SqlConnection DBCo = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBContacts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand comand = new SqlCommand();     // skapar sql 'comand' 
            comand.CommandText = "ReadAllContact";    // CommandText är lika med 'select'ect
            comand.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure
            comand.Connection = DBCo;  // överför comand till databasen
            SqlDataReader result = comand.ExecuteReader();  // executes och resultaten hamnar il 'result'

            while (result.Read())

            {
                Contact co = new Contact();
                co.ID = (int)result[0];
                co.SSN = result[1].ToString();
                co.Firstname = result[2].ToString();
                co.Lastname = result[3].ToString();
                LiCo.Add(co);
            }
            DBCo.Close();
            return LiCo;

        }



        public static void CreateContact(Contact co)   // id in parameter
        {
            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            var DBCo = ÖppnaAnslutning();
            DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand comand = new SqlCommand();     // skapar sql 'comand' 
            comand.CommandText = "cretecontact2";    // CommandText är lika med 'select'ect
            comand.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure

            comand.Parameters.Add(new SqlParameter("@SSN", co.SSN));
            comand.Parameters.Add(new SqlParameter("@fn", co.Firstname));
            comand.Parameters.Add(new SqlParameter("@ln", co.Lastname));

            // SqlParameter Par = new SqlParameter();
            //   Par.ParameterName = "@SSN";
            //   Par.Value = co.SSN;
            //  Par.SqlDbType = System.Data.SqlDbType.VarChar;
            //     Par.Size = 32;
            // Par.Direction = System.Data.ParameterDirection.Input;
            //    comand.Parameters.Add(Par);


            // SqlParameter Par1 = new SqlParameter();
            //   Par1.ParameterName = "@firstname";
            //   Par1.Value = co.SSN;
            //  Par1.SqlDbType = System.Data.SqlDbType.VarChar;
            //     Par.Size = 32;
            // Par1.Direction = System.Data.ParameterDirection.Input;
            //    comand.Parameters.Add(Par);

            // SqlParameter Par2 = new SqlParameter();
            //   Par2.ParameterName = "@lastname";
            //   Par2.Value = co.SSN;
            //  Par2.SqlDbType = System.Data.SqlDbType.VarChar;
            //     Par2.Size = 32;
            // Par2.Direction = System.Data.ParameterDirection.Input;
            //    comand.Parameters.Add(Par);




            comand.Connection = DBCo;  // överför comand till databasen
            int r = comand.ExecuteNonQuery();  // executes och resultaten hamnar il 'result'
                                               //   Contact co = new Contact();

            Console.WriteLine("Sono state modificate {r} ");

            DBCo.Close();
        }

        public static int UpdateContact(Contact co)
        {
            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            SqlConnection DBCo = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBContacts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand com = new SqlCommand();     // skapar sql 'comand' 
            com.CommandText = "UpdateContact";    // CommandText är lika med 'select'ect
            com.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure

            //    comand.Parameters.Add(new SqlParameter("@SSN", co.SSN));
            //    comand.Parameters.Add(new SqlParameter("@fn", co.Firstname));
            //   comand.Parameters.Add(new SqlParameter("@ln", co.Lastname));

            SqlParameter Par = new SqlParameter();
            Par.ParameterName = "@ssn";
            Par.Value = co.SSN;
            Par.SqlDbType = System.Data.SqlDbType.VarChar;
            Par.Size = 32;
            Par.Direction = System.Data.ParameterDirection.Input;
            com.Parameters.Add(Par);


            SqlParameter Par1 = new SqlParameter();
            Par1.ParameterName = "@fname";
            Par1.Value = co.Firstname;
            Par1.SqlDbType = System.Data.SqlDbType.VarChar;
            Par.Size = 32;
            Par1.Direction = System.Data.ParameterDirection.Input;
            com.Parameters.Add(Par1);

            SqlParameter Par2 = new SqlParameter();
            Par2.ParameterName = "@lname";
            Par2.Value = co.Lastname;
            Par2.SqlDbType = System.Data.SqlDbType.VarChar;
            Par2.Size = 32;
            Par2.Direction = System.Data.ParameterDirection.Input;
            com.Parameters.Add(Par2);

            SqlParameter Par3 = new SqlParameter();
            Par3.ParameterName = "@id";
            Par3.Value = co.ID;
            Par3.SqlDbType = System.Data.SqlDbType.Int;
            // Par.Size = 32;
            Par3.Direction = System.Data.ParameterDirection.Input;
            com.Parameters.Add(Par3);




            com.Connection = DBCo;  // överför comand till databasen
            int r = com.ExecuteNonQuery();  // executes och resultaten hamnar il 'result'
                                            //   Contact co = new Contact();


            // Console.WriteLine("Sono state modificate {r} righe ");

            DBCo.Close();
            return r;
        }

        public static int DeleteContact(int id)
             {
            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            var DBCo = ÖppnaAnslutning();
        DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand com = new SqlCommand();     // skapar sql 'comand' 
            com.CommandText = "DeleteContact";    // CommandText är lika med 'select'ect
            com.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure

            var Par = new SqlParameter();
        Par.ParameterName = "@id";
            Par.Value = id;
            Par.SqlDbType = System.Data.SqlDbType.Int;
            Par.Direction = System.Data.ParameterDirection.Input;
            com.Parameters.Add(Par);



            com.Connection = DBCo;  // överför comand till databasen
            int r = com.ExecuteNonQuery();  // executes och resultaten hamnar il 'result'
                                            //   Contact co = new Contact();


        // Console.WriteLine("Sono state modificate {r} righe ");

        DBCo.Close();
            return r;
        }

        public static void CreateContactInfo(ContactInfo coI)   // id in parameter
        {
            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            var DBCo = ÖppnaAnslutning();
            DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand comand = new SqlCommand();     // skapar sql 'comand' 
            comand.CommandText = "CreateContactInfo";    // CommandText är lika med 'select'ect
            comand.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure

        
         

          SqlParameter Par = new SqlParameter();
              Par.ParameterName = "@info";            
               Par.Value = coI.info;
              Par.SqlDbType = System.Data.SqlDbType.VarChar;
                Par.Size = 32;
          Par.Direction = System.Data.ParameterDirection.Input;
               comand.Parameters.Add(Par);


            SqlParameter Par1 = new SqlParameter();
            Par1.ParameterName = "@contactID";
            Par1.Value = coI.ContactID;
            Par1.SqlDbType = System.Data.SqlDbType.Int;
         
            Par1.Direction = System.Data.ParameterDirection.Input;
            comand.Parameters.Add(Par1);

            SqlParameter Par2 = new SqlParameter();
            Par2.ParameterName = "@CID";
            
            Par2.SqlDbType = System.Data.SqlDbType.Int;

            Par2.Direction = System.Data.ParameterDirection.Output;
            comand.Parameters.Add(Par2);


            // SqlParameter Par2 = new SqlParameter();
            //   Par2.ParameterName = "@lastname";
            //   Par2.Value = co.SSN;
            //  Par2.SqlDbType = System.Data.SqlDbType.VarChar;
            //     Par2.Size = 32;
            // Par2.Direction = System.Data.ParameterDirection.Input;
            //    comand.Parameters.Add(Par);




            comand.Connection = DBCo;  // överför comand till databasen
            int r = comand.ExecuteNonQuery();  // executes och resultaten hamnar il 'result'
                                               //   Contact co = new Contact();

            Console.WriteLine("Sono state modificate {r} ");

            DBCo.Close();
        }
        public static List<ContactInfo> ReadAllContactInfo()
        {
            List<ContactInfo> LiCo = new List<ContactInfo>();

            // skapar en anslutning till sql server som vi ska kalla för DBCo 
            var DBCo = ÖppnaAnslutning();

            DBCo.Open();     // med metoden open() öppnar vi databasen 
            SqlCommand comand = new SqlCommand();     // skapar sql 'comand' 
            comand.CommandText = "ReadAllContactInfo";    // CommandText är lika med 'select'ect
            comand.CommandType = System.Data.CommandType.StoredProcedure; // CommandType kan vara en Text eller procedure
            comand.Connection = DBCo;  // överför comand till databasen
            SqlDataReader result = comand.ExecuteReader();  // executes och resultaten hamnar il 'result'

            while (result.Read())

            {
                ContactInfo co = new ContactInfo();
                co.ID = (int)result[0];
                co.info = result[1].ToString();
                co.ContactID = (int)result[2];
            
                LiCo.Add(co);
            }
            DBCo.Close();
            return LiCo;

        }
    }


}


