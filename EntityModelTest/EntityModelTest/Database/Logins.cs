using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelTest.Database
{
    public class Logins
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }

        //public int Student_ID { get; set; }
        public Students Student { get; set; }
    }
}
