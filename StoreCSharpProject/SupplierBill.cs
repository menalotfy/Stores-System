using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
   public class SupplierBill
    {
        public int ID { get; set; }
        public bool Type { get; set; }
        public DateTime BillDate { get; set; }
        public double BillValue { get; set; }

        [ForeignKey("employee")]
        public int employee_Id { get; set; }
        public Employee employee { get; set; }

        [ForeignKey("suppliers")]
        public int suppliers_Id { get; set; }
        public Suppliers suppliers { get; set; }

        public bool status { get; set; }

        // public Budget Budget { get; set; }
        public ICollection<SuppliersBillDetails> SuppliersBillDetails { get; set; }
        public ICollection<SupplierBillPayment> SupplierBillPayments { get; set; }
    }
}
