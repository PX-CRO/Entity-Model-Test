using EntityModelTest.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelTest.Database
{
    public class Discontinuities
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public bool Status { get; set; }

        //public int Student_ID { get; set; }
        public Students Student { get; set; }
    }
}
