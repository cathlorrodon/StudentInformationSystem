using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_MODEL;

namespace SIS_DATA
{
    public class InMemoryFacultyInfo
    {
        public static List<FacultyInfo> FacultyInfos = new List<FacultyInfo>();

        public InMemoryFacultyInfo()
        {
            getListFacultyInfo();
        }

        public List<FacultyInfo> getList()
        {
            return FacultyInfos;
        }

        public FacultyInfo GetFacultyInfoByFacultyNumber(string facultyNumber)
        {
            return FacultyInfos.FirstOrDefault(faculty => faculty.facultyNumber.Equals(facultyNumber));
        }

        private void getListFacultyInfo()
        {
            FacultyInfo faculty1 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "Indaleen Quinsayas",
                subjectHeld = "Integrative Programming and Technologies 1",
                email = "indaleenquinsayas@pup.com"
            };

            FacultyInfo faculty2 = new FacultyInfo
            {
                facultyNumber = "FA0002BN2016",
                facultyName = "Ramon Almazan ",
                subjectHeld = "Human Computer Interaction",
                email = "ramonalmazan@pup.com"
            };

            FacultyInfo faculty3 = new FacultyInfo
            {
                facultyNumber = "FA0003BN2016",
                facultyName = "Glorina Orozco",
                subjectHeld = "People and Earth's Ecosystem",
                email = "glorinaorozco@pup.com"
            };

            FacultyInfo faculty4 = new FacultyInfo
            {
                facultyNumber = "FA0004BN2016",
                facultyName = "Julian Lorico",
                subjectHeld = "Quantitative Methods with Modeling and Simulation ",
                email = "julianlorico@pup.com"
            };

            FacultyInfo faculty5 = new FacultyInfo
            {
                facultyNumber = "FA0005BN2016",
                facultyName = "Ivan Macha",
                subjectHeld = "Information Management",
                email = "ivanmacha@pup.com"
            };

            FacultyInfo faculty6 = new FacultyInfo
            {
                facultyNumber = "FA0006BN2016",
                facultyName = "Edmundo Dela Cruz",
                subjectHeld = "Object Oriented Programming",
                email = "edmundodelacruz@pup.com"
            };

            FacultyInfo faculty7 = new FacultyInfo
            {
                facultyNumber = "FA0007BN2016",
                facultyName = "Noemi Apostol",
                subjectHeld = "Team Sports",
                email = "noemiapostol@pup.com"
            };

            FacultyInfos.Add(faculty1);
            FacultyInfos.Add(faculty2);
            FacultyInfos.Add(faculty3);
            FacultyInfos.Add(faculty4);
            FacultyInfos.Add(faculty5);
            FacultyInfos.Add(faculty6);
            FacultyInfos.Add(faculty7);


        }
    }
}
