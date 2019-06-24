using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class GeneralBill
    {
        public int ID { get; set; }
        public DateTime BillDate { get; set; }
        public double totalCost { get; set; }

        public bool status { get; set; }
        public string Type { get; set; }

        [ForeignKey("employee")]
        public int employee_Id { get; set; }
        public Employee employee { get; set; }

        [ForeignKey("customers")]
        public int customers_Id { get; set; }
        public Customers customers { get; set; }

        //public Returned Returned { get; set; }

        public ICollection<GeneralBillPayment> GeneralBillPayments { get; set; } = new List<GeneralBillPayment>();

        public ICollection<GeneralBillDetails> generalBillDetails { get; set; } = new List<GeneralBillDetails>();

    }
}
