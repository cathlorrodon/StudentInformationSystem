using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;

namespace SIS_RULES
{
    public class FacultyFormRules
    {
        public static void actionFacultyWelcomePage()
        {
            int status;
            do
            {
                status = FacultyForm.facultyWelcomePage();
                switch (status)
                {
                    case 0: //log out
                        FacultyForm.logOut();
                        break;

                    case 1: //Faculty Information
                        PrintInfos.PrintFacultyInfo(StudentForm.username);
                        actionFacultyWelcomePage();
                        break;

                    case 2: //Grading System
                        FacultyForm.gradingSystem();
                        actionFacultyWelcomePage();
                        break;
                    case 3: //Attendance
                        FacultyForm.attendance();
                        actionFacultyWelcomePage();
                        break;

                    case 4://Schedule

                        break;
                }
            } while (status == null);
        }
    }
}

