using System;

namespace SIS_UI
{
    public class SubjectForm
    {
        // Welcome Page
        public static void CurrentSubjectPage()
        {
		ViewSecondYearSecondSemester();
        }

        public static void ViewFirstYearFirstSemester()
        {
            Console.WriteLine("First Year First sem");
            Console.WriteLine("\tSubject code\tSubject Description");
            Console.WriteLine("1\tACCO 20213\tAccounting Principles");
            Console.WriteLine("2\tCOMP 20013\tIntroduction to Computing");
            Console.WriteLine("3\tCOMP 20023\tComputer Programming 1");
            Console.WriteLine("4\tCWTS 10013\tCivic Welfare Training Service 1");
            Console.WriteLine("5\tGEED 10053\tMathematics in the Modern World");
            Console.WriteLine("6\tGEED 10063\tPurposive Communication");
            Console.WriteLine("7\tGEED 10103\tFilipinolohiya at Pambansang Kaunlaran");
            Console.WriteLine("8\tPHED 10012\tPhysical Fitness and Self-Testing Activities");
        }

        public static void ViewFirstYearSecondSemester()
        {
            Console.WriteLine("First Year Second sem");
            Console.WriteLine("\tSubject code\tSubject Description");
            Console.WriteLine("1\tCOMP 20033\tComputer Programming 2");
            Console.WriteLine("2\tCOMP 20043\tDiscrete Structures 1");
            Console.WriteLine("3\tCWTS 10023\tCivic Welfare Training Service 2");
            Console.WriteLine("4\tGEED 10033\tReadings in Philippine History");
            Console.WriteLine("5\tGEED 10113\tPagsasalin sa Kontekstong Filipino");
            Console.WriteLine("6\tGEED 20023\tPolitics, Governance and Citizenship");
            Console.WriteLine("7\tPHED 10022\tRhythmic Activities");
        }

        public static void ViewSecondYearFirstSemester()
        {
            Console.WriteLine("Second Year First sem");
            Console.WriteLine("\tSubject code\tSubject Description");
            Console.WriteLine("1\tCOMP 20063\tData Structures and Algorithms");
            Console.WriteLine("2\tCOMP 20103\tOperating Systems");
            Console.WriteLine("3\tCOMP 20173\tData Communications and Networking");
            Console.WriteLine("4\tGEED 10023\tUnderstanding the Self");
            Console.WriteLine("5\tGEED 10223\tWorld Literature");
            Console.WriteLine("6\tGEED 20093\tReading Visual Arts");
            Console.WriteLine("7\tINTE 30013\tProgramming 3 (Structured Programming)");
            Console.WriteLine("8\tPHED 10032\tIndividual/Dual/Combative Sports");
        }

        public static void ViewSecondYearSecondSemester()
        {
            Console.WriteLine("Second Year Second sem");
            Console.WriteLine("\tSubject code\tSubject Description");
            Console.WriteLine("1\tCOMP 20083\tObject Oriented Programming");
            Console.WriteLine("2\tCOMP 20093\tInformation Management");
            Console.WriteLine("3\tCOMP 20143\tHuman Computer Interaction");
            Console.WriteLine("4\tCOMP 20193\tNetwork Administration");
            Console.WriteLine("5\tCOMP 20203\tQuantitative Methods with Modeling and Simulation");
            Console.WriteLine("6\tGEED 20113\tPeople and the Earth's Ecosystem");
            Console.WriteLine("7\tINTE 30023\tIntegrative Programming and Technologies 1");
            Console.WriteLine("8\tPHED 10042\tTeam Sports");
        }


            // Ask the user if they want to see other semesters

	    public static void SeeOtherSem()
        {
            Console.WriteLine("\nDo you want to see the other semesters? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Y")
            {
                Console.WriteLine("\nAvailable semesters:");
                Console.WriteLine("[1] First Year First sem");
                Console.WriteLine("[2] First Year Second sem");
                Console.WriteLine("[3] Second Year First sem");
                Console.WriteLine("[4] Second Year Second sem");
                Console.Write("Select a semester: ");
                int semesterChoice = Convert.ToInt32(Console.ReadLine());

                switch (semesterChoice)
               	{
                    case 1:
                        ViewFirstYearFirstSemester();
                        break;
                    case 2:
                        ViewFirstYearSecondSemester();
                        break;
                    case 3:
                        ViewSecondYearFirstSemester();
                        break;
                    case 4:
                        ViewSecondYearSecondSemester();
                        break;
                    default:
                        Console.WriteLine("Invalid semester choice.");
                        break;
			    }
		    }
        }
   	}
}
