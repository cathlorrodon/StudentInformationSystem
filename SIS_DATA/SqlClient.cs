using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using SIS_MODEL;
using System.Diagnostics;

namespace SIS_DATA
{
    public class SqlClient 
    {
        private string connectionString
        = "Data Source=LAPTOP-EKPAGTRE\\SQLEXPRESS;Initial Catalog=PUPStudentInformationSytem;Integrated Security=True;";
        private SqlConnection sqlConnection;

        public SqlClient()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        StudentPersonalInfo student = new StudentPersonalInfo();
        StudentInfo studentInfo = new StudentInfo();

        //method for viewing student personal information
        public void showStudentPersonalInfo(string sisAccountNumber)
        {
            //public string sisAccount = 
            //StudentPersonalInfo student = new StudentPersonalInfo();
            //sqlConnection.Open();
            string sqlQuery = "SELECT * FROM StudentPersonalInfo where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //StudentPersonalInfo student = new StudentPersonalInfo();
                student.SISAccountNumber = reader.GetString(1);
                student.fullname = reader.GetString(2);
                student.Gender = reader.GetString(3);
                student.DateofBirth = reader.GetDateTime(4);
                student.placeofBirth = reader.GetString(5);
                student.mobileNo = reader.GetString(6);
                student.emailAddress = reader.GetString(7);
                student.residentialAddress = reader.GetString(8);
                student.permanentAdress = reader.GetString(9);

                //SIS_UI
                Console.WriteLine($"\nSIS Account Number: {student.SISAccountNumber}\n" +
                    $"Full Name: {student.fullname}\n" +
                    $"Gender: {student.Gender}\n" +
                    $"Date Of Birth: {student.DateofBirth}\n" +
                    $"Place Of Birth: {student.placeofBirth}\n" +
                    $"Mobile Number: {student.mobileNo}\n" +
                    $"Email Address: {student.emailAddress}\n" +
                    $"Residential Address: {student.residentialAddress}\n" +
                    $"Permanent Address: {student.permanentAdress}");
                
                /*string formattedInfo = $"\nStudent Personal Information\n" +
                    $"SIS Account Number: {student.SISAccountNumber}\n" +
                    $"Full Name: {student.fullname}\n" +
                    $"Gender: {student.Gender}\n" +
                    $"Date Of Birth: {student.DateofBirth}\n" +
                    $"Place Of Birth: {student.placeofBirth} \n" +
                    $"Mobile Number: {student.mobileNo} \n" +
                    $"Email Address: {student.emailAddress} \n" +
                    $"Residential Address: {student.residentialAddress} \n" +
                    $"Permanent Address: {student.permanentAdress} \n" ;
                Trace.WriteLine(formattedInfo); */

                //return formattedInfo;

                //sqlConnection.Close();
            }
            sqlConnection.Close();
        }

        //method to view Student Information
        public void showStudentInfo(string sisAccountNumber)
        {
            string sqlQuery = "SELECT * FROM StudentInfo where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                studentInfo.SISAccountNumber = reader.GetString(1);
                studentInfo.fullName = reader.GetString(2);
                studentInfo.course = reader.GetString(3);
                studentInfo.year = reader.GetInt32(4);
                studentInfo.section = reader.GetInt32(5);

                Console.WriteLine($"\nSIS Account Number: {studentInfo.SISAccountNumber}\n" +
                    $"Full Name: {studentInfo.fullName}\n" +
                    $"Course: {studentInfo.course}\n" +
                    $"Year: {studentInfo.year}\n" +
                    $"Section: {studentInfo.section}\n");
            }
            sqlConnection.Close();
        }

        //method for updating personal information
        public void updatePlaceOfBirth(string sisAccountNumber)
        {
            string sqlQuery = "UPDATE StudentPersonalInfo Set PlaceOfBirth = @PlaceOfBirth";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();


        }
    }
}
