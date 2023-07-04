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
                facultyName = "",
                subjectHeld = "",
                email = ""
            };

            FacultyInfo faculty2 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "",
                subjectHeld = "",
                email = ""
            };

            FacultyInfo faculty3 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "",
                subjectHeld = "",
                email = ""
            };

            FacultyInfo faculty4 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "",
                subjectHeld = "",
                email = ""
            };

            FacultyInfo faculty5 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "",
                subjectHeld = "",
                email = ""
            };

            FacultyInfo faculty6 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "",
                subjectHeld = "",
                email = ""
            };

            FacultyInfo faculty7 = new FacultyInfo
            {
                facultyNumber = "FA0001BN2016",
                facultyName = "",
                subjectHeld = "",
                email = ""
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
