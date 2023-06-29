using System;
using System.Collections.Generic;
using AM_Rules;
using AM_Models;
using SIS_RULES;
using SIS_UI;


namespace AM_UI
{
    internal class Program
    {
        //public static string username;

        public static void Main(string[] args)
        {
            //AM_Rules
            LoginRules login = new LoginRules();
            RegisterRules register = new RegisterRules();
            RecoverRules recover = new RecoverRules();
            //AM_MODEL
            SISAccount account;
            SISType accountType;
            //options
            int status;
            string ifSuccess;


            do
            {
                status = ShowOptions();
                switch (status)
                {
                    case 0: break;
                    case 1:
                    case 2:
                        int action = ShowForm();
                        switch (action)
                        {
                            case 1: //login
                                //ifSuccess = Login(status);
                                //Console.WriteLine(ifSuccess);
                                Login(status);
                                break;
                            case 2: //Sign in
                                Register(status);
                                break;
                            case 3://Recover
                                ifSuccess = Recover();
                                Console.WriteLine(ifSuccess);
                                break;
                            default:
                                Console.WriteLine("Incorrent Input.");
                                break;
                        }
                        break;
                    case 3:
                        ifSuccess = Login(status);
                        Console.WriteLine(ifSuccess);
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }
            } while (status == 0);


            //Methods for login
            int ShowOptions()
            {
                Console.Write("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Welcome. Are you a...?");
                Console.WriteLine("[1]STUDENT");
                Console.WriteLine("[2]TEACHER");
                Console.WriteLine("[3]ADMIN");
                Console.WriteLine("[0]EXIT");
                Console.Write("Input: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            int ShowForm()
            {
                Console.WriteLine("\nPlease choose an action: ");
                Console.WriteLine("[1]Login");
                Console.WriteLine("[2]Sign Up");
                Console.WriteLine("[3]Forgot Password");
                Console.Write("Input: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            //Login
            string Login(int type)
            {
                if (type == 1)
                { accountType = SISType.Student; }
                else if (type == 2)
                { accountType = SISType.Faculty; }
                else
                { accountType = SISType.Admin; }

                Console.WriteLine("\nEnter the following information: ");
                Console.Write("Account number: ");
                StudentForm.username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                account = login.Login(StudentForm.username, password, accountType);

                if (account != null && type == 1)
                {
                    StudentFormRules.actionStudentWelcomePage();
                    return "";
                }
                else if (account != null && type == 2)
                {
                    FacultyFormRules.actionFacultyWelcomePage();
                    return "";
                }
                else
                { return "Incorrect Credentials."; }
            }
            void Register(int type)
            {
                string username, password, email;
                bool format;
                Console.WriteLine("\nCreating new account...");

                if (type == 1)
                { accountType = SISType.Student; }
                else
                { accountType = SISType.Faculty; }


                do
                {
                    Console.Write("Account number: ");
                    username = Console.ReadLine();
                    format = register.CheckFormat(username, accountType);
                    if (format == false) { Console.WriteLine("Incorrect Account Number format."); }
                } while (format == false);

                Console.Write("Email address: ");
                email = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();

                register.CreateAccount(username, email, password, accountType);
                Console.WriteLine("Successfully Registered.");
            }
            string Recover()
            {
                Console.WriteLine("\nRecovering Account...");
                Console.Write("Please enter your email: ");
                string email = Console.ReadLine();
                account = recover.FindAccountByEmail(email);

                if (account != null)
                {
                    Console.WriteLine("\nAccount Found!");
                    Console.Write("Type your new password: ");
                    string newPassword = Console.ReadLine();
                    Console.Write("Type your new password again: ");
                    string newPassword2 = Console.ReadLine();
                    bool result = recover.RecoverSISAccountByEmail(email, newPassword, newPassword2);

                    if (result == true)
                    { return "Successfully recovered your account."; }
                    else { return "Password are not the same."; }
                }
                else
                { return "Account not found."; }
            }


        }
    }
}