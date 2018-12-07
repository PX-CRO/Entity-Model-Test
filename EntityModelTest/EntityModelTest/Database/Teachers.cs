using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelTest.Database
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string TCno { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public DateTime? DateOfLeave { get; set; }
        public string Address { get; set; }
        public byte[] Photo { get; set; }

        //public int Lesson_ID { get; set; }
        public Lessons Lesson { get; set; }

        public string Description { get; set; }
    }
}
