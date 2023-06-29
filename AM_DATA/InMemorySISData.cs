using AM_Models;

namespace AM_Data
{
    public class InMemorySISData
    {
        private List<SISAccount> SISAccounts = new List<SISAccount>();

        public InMemorySISData()
        { CreateAccounts(); }

        public List<SISAccount> GetList()
        { return SISAccounts; }
        private void CreateAccounts()
        {
            SISAccount admin1 = new SISAccount
            {
                SISAccountNumber = "erwin",
                EmailAddress = "espartoerwin@gmail.com",
                Password = "erwin123",
                Type = SISType.Admin,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            SISAccount admin2 = new SISAccount
            {
                SISAccountNumber = "jaspher",
                EmailAddress = "baetjaspher@gmail.com",
                Password = "jaspher456",
                Type = SISType.Admin,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            SISAccount admin3 = new SISAccount
            {
                SISAccountNumber = "kenneth",
                EmailAddress = "odgienkenneth@gmail.com",
                Password = "kenneth789",
                Type = SISType.Admin,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            SISAccount admin4 = new SISAccount
            {
                SISAccountNumber = "lilac",
                EmailAddress = "lilacgoodrich@gmail.com",
                Password = "lilac456",
                Type = SISType.Admin,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount student1 = new SISAccount
            {
                SISAccountNumber = "2021-00066-BN-0",
                EmailAddress = "perezstephenmathew360@gmail.com",
                Password = "stephen",
                Type = SISType.Student,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount student2 = new SISAccount
            {
                SISAccountNumber = "2021-00428-BN-0",
                EmailAddress = "encisohappy@gmail.com",
                Password = "happy",
                Type = SISType.Student,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty1 = new SISAccount
            {
                SISAccountNumber = "FA0001BN2016",
                EmailAddress = "indaleenquinsayas@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty2 = new SISAccount
            {
                SISAccountNumber = "FA0002BN2016",
                EmailAddress = "ramonalmazan@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty3 = new SISAccount
            {
                SISAccountNumber = "FA0003BN2016",
                EmailAddress = "glorinaorozco@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty4 = new SISAccount
            {
                SISAccountNumber = "FA0004BN2016",
                EmailAddress = "julianlorico@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty5 = new SISAccount
            {
                SISAccountNumber = "FA0005BN2016",
                EmailAddress = "ivanmacha@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty6 = new SISAccount
            {
                SISAccountNumber = "FA0006BN2016",
                EmailAddress = "eddelacruz@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            SISAccount faculty7 = new SISAccount
            {
                SISAccountNumber = "FA0006BN2016",
                EmailAddress = "noyapostol@gmail.com",
                Password = "facultypass",
                Type = SISType.Faculty,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };
            SISAccounts.Add(admin1);
            SISAccounts.Add(admin2);
            SISAccounts.Add(admin3);
            SISAccounts.Add(admin4);
            SISAccounts.Add(student1);
            SISAccounts.Add(student2);
            SISAccounts.Add(faculty1);
            SISAccounts.Add(faculty2);
            SISAccounts.Add(faculty3);
            SISAccounts.Add(faculty4);
            SISAccounts.Add(faculty5);
            SISAccounts.Add(faculty6);
            SISAccounts.Add(faculty7);

        }
    }
}