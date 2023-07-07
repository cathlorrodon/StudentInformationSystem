using System;

namespace SIS_UI
{
    public class StudentForm
    {
        public static string username;

        //Welcome Page
        public static int studentWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Student Information");
            Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[3]Grading System");
            Console.WriteLine("[4]Attendance");
            Console.WriteLine("[5]Schedule");
            Console.WriteLine("[6]Subject");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //Interface when clicked Personal Information 
        public static int actionStudentPersonalInfo()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Go Back");
            Console.WriteLine("[1]View Student Personal Information");
            Console.WriteLine("[2]Update Student Personal Information");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //Interface when updating an Personal Information
        public static int actionUpdateStudentPersonalInfo()
        {
            Console.WriteLine("\nCurrent personal information\n");
            //PrintInfos.PrintStudentPersonalInfo(StudentForm.username);

            Console.WriteLine("\nEDIT PERSONAL INFORMATION\n");
            Console.WriteLine("Please choose an action: ");
            Console.WriteLine("[0] - Cancel");
            Console.WriteLine("[1] - Name");
            Console.WriteLine("[2] - Birthday");
            Console.WriteLine("[3] - SIS Account Number");
            Console.WriteLine("[4] - Date of Birth");
            Console.WriteLine("[5] - Place of Birth");
            Console.WriteLine("[6] - Mobile Number");
            Console.WriteLine("[7] - Email Address");
            Console.WriteLine("[8] - Residential Address");
            Console.WriteLine("[9] - Permanent Address");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string getSISAcc()
        {
            Console.WriteLine("\nEnter the SIS account number of the student to verify changes:");
            return Console.ReadLine();
        }
        public static string updatePlaceOfBirth()
        {
            Console.WriteLine("\nEnter new Place Of Birth: ");
            return Console.ReadLine();
        }

        public static string updateEmailAddress()
        {
            Console.WriteLine("Enter new Email Address: ");
            return Console.ReadLine();
        }

        public static string updateResidentialAdd()
        {
            Console.WriteLine("Enter new Residential Address: ");
            return Console.ReadLine();
        }

        public static string updatePermanentAdd()
        {
            Console.WriteLine("Enter new Permanent Address: ");
            return Console.ReadLine();
        }

        public static string updateContactNumber()
        {
            Console.WriteLine("Enter new Contact Number: ");
            return Console.ReadLine();
        }

        //method to call success update
        public static void successUpdate()
        {
            Console.WriteLine("\nStudent personal information updated successfully.");
            Console.WriteLine("Here's the updated personal information\n");

            //PrintInfos.PrintStudentPersonalInfo(username);
        }

        public static void nonEditable()
        {
            Console.WriteLine("\nThis information is not editable");
            Console.WriteLine("Please try again");
        }

        public static void attendance()
        {
            Console.WriteLine("On progress of Nico's Group");
        }

        public static void gradingSystem()
        {
            Console.WriteLine("\nOn Progress of Rizon's Group\n");
        }

        public static int scheduleSystem()
        {
            Console.WriteLine("\nPlease Choose an Action:");
            Console.WriteLine("[1] Monday");
            Console.WriteLine("[2] Tuesday");
            Console.WriteLine("[3] Wednesday");
            Console.WriteLine("[4] Thursday");
            Console.WriteLine("[5] Friday");
            Console.WriteLine("[6] Saturday");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void scheduleMonday()
        {
            Console.WriteLine("No schedule");
        }

        public static void scheduleTuesday()
        {
            Console.WriteLine("\n1. Information Management | 8:00AM to 12:00PM");
            Console.WriteLine("2. People's Earth & Ecosystem | 2:00PM to 5:00PM");
            Console.WriteLine("3. Information Management | 5:15PM to 7:00PM");
        }

        public static void scheduleWednesday()
        {
            Console.WriteLine("\nNo schedule");
            //return Console.ReadLine();
        }

        public static void scheduleThursday()
        {
            Console.WriteLine("\n1. Network Administration | 8:00AM to 1:00PM");
            Console.WriteLine("2. Physical Education | 4:00PM to 6:00PM");
            Console.WriteLine("3. Quantitative Method | 6:00PM to 9:00PM");
            //return Console.ReadLine();
        }

        public static void scheduleFriday()
        {
            Console.WriteLine("\nNo schedule");
            //return Console.ReadLine();
        }

        public static void scheduleSaturday()
        {
            Console.WriteLine("\n1. Integrative Programming | 8:00AM to 12:30PM");
            Console.WriteLine("2. Object Oriented Programming | 2:00PM to 8:00PM");
            //return Console.ReadLine();
        }

    }
}

