using System;
namespace SIS_UI
{
    public class FacultyForm
    {
        public static int facultyWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Faculty Information");
            //Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[2]Grading System");
            Console.WriteLine("[3]Attendance");
            Console.WriteLine("[4]Schedule");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //Method for log out
        public static void logOut()
        {
            Console.WriteLine("\nLog out Successfully\n");
            Environment.Exit(0);
            //Console.ReadKey();
        }

        //method for calling attendance system
        public static void attendance()
        {
            Console.WriteLine("On progress of Nico's Group");
        }

        //method for callig grading system
        public static void gradingSystem()
        {
            Console.WriteLine("\nOn Progress of Rizon's Group\n");
        }
    }
}

