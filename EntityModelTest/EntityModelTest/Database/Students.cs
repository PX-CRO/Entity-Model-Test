using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelTest.Database
{
    public class Students
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string StudentNo { get; set; }
        public string TCno { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public DateTime? DateOfLeave{ get; set; }
        public string Address { get; set; }
        public string ParentName { get; set; }
        public string ParentPhone1 { get; set; }
        public string ParentPhone2 { get; set; }
        public bool ParentGender { get; set; }
        public byte[] Photo { get; set; }

        //public int Groups_ID { get; set; }
        //public int Classes_ID { get; set; }
        public Groups Group { get; set; }
        public Classes Clas { get; set; }

        public string Description { get; set; }
    }
}
