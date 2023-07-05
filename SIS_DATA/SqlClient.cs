using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using SIS_MODEL;

namespace SIS_DATA
{
    public class SqlClient 
    {
        //static string connectionString = "Data Source =localhost; Initial Catalog = ; Integrated Security = true;";
        //static SqlConnection sqlConnection;

        private string connectionString
        //= "Data Source =localhost;Initial Catalog = PUPStudentInformationSytem; Integrated Security = True;";
        = "Data Source=LAPTOP-EKPAGTRE\\SQLEXPRESS;Initial Catalog=PUPStudentInformationSytem;Integrated Security=True;";
        //Data Source=LAPTOP-EKPAGTRE\SQLEXPRESS;Initial Catalog=PUPStudentInformationSytem;Integrated Security=True
        private SqlConnection sqlConnection;

        public SqlClient()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        //method for viewing student personal information
        public void showStudentPersonalInfo()
        {
            //sqlConnection.Open();
            string sqlQuery = "SELECT * FROM StudentPersonalInfo";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                StudentPersonalInfo student = new StudentPersonalInfo();
                student.SISAccountNumber = reader.GetString(1);
                student.fullname = reader.GetString(2);
                student.Gender = reader.GetString(3);
                student.DateofBirth = reader.GetDateTime(4);
                student.placeofBirth = reader.GetString(5);
                student.mobileNo = reader.GetString(6);
                student.emailAddress = reader.GetString(7);
                student.residentialAddress = reader.GetString(8);
                student.permanentAdress = reader.GetString(9);

                Console.WriteLine($"{student.SISAccountNumber}\n\n{student.fullname}\n{student.Gender}\n{student.DateofBirth}\n{student.placeofBirth}\n{student.mobileNo}\n,{student.emailAddress}\n{student.residentialAddress}\n{student.permanentAdress}");

                //sqlConnection.Close();
            }

            sqlConnection.Close();
        }
    }
}
