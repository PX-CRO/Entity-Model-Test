using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelTest.Database
{
    public class Payments
    {
        public int Id { get; set; }
        public string PayerNameSurname { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int PaymentTotal { get; set; }

        //public int Student_ID { get; set; }
        public Students Student { get; set; }
    }
}
