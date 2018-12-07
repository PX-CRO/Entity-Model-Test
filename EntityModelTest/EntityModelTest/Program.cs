using EntityModelTest.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ClassroomContext())
            {
                var stud = new Students()
                {
                    Type = "Student",
                    StudentNo = "150304032",
                    TCno = "12345678910",
                    FName = "Hüseyin",
                    LName = "Biçen",
                    Gender = true,
                    Birthday = new DateTime(1996, 06, 13),
                    Phone = "+905438379296",
                    eMail = "huseynbicen@gmail.com",
                    Password = "abc123456",
                    Status = true,
                    DateOfJoin = DateTime.Now.Date,
                    DateOfLeave = null,
                    Address = "Siirt Kezer Yerleşkesi, KYK Erkek Öğrenci Yurdu B-28",
                    ParentName = "Veysi",
                    ParentPhone1 = "+905438379296",
                    ParentPhone2 = null,
                    ParentGender = true,
                    Photo = null,
                    Group = null,
                    Clas = null,
                    Description = "He is perfect person"
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine("Bitti");
                Console.Read();
            }
        }
    }
}
