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

        public static void scheduleSystem(string facultyNumber)
        {
            Dictionary<string, string> facultySchedule = new Dictionary<string, string>()
    {
        { "FA0001BN2016", "Integrative Programming and Technologies 1: Saturday, 8:00 AM - 12:30 PM" },
        { "FA0002BN2016", "Human Computer Interaction: Tuesday, 5:15 PM - 7:00 PM" },
        { "FA0003BN2016", "People and Earth's Ecosystem: Tuesday, 2:00 PM - 5:00 PM" },
        { "FA0004BN2016", "Quantitative Methods with Modeling and Simulation: Thursday, 6:00 PM - 9:00 PM" },
        { "FA0005BN2016", "Information Management: Tuesday, 8:00 AM - 12:00 PM" },
        { "FA0006BN2016", "Object Oriented Programming: Saturday, 2:00 PM - 7:00 PM" },
        { "FA0007BN2016", "Team Sports: Thursday, 4:00 PM - 6:00 PM" }
    };


            string schedule;
            if (facultySchedule.TryGetValue(facultyNumber, out schedule))
            {
                Console.WriteLine($"\nSubject: {schedule}");
            }
            else
            {
                Console.WriteLine("\nNo schedule available for the selected faculty number.");
            }
        }

    }
}

