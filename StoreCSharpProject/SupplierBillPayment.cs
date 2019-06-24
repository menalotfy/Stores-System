using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
   public class SupplierBillPayment
    {
        public int ID { get; set; }
        public double Paied { get; set; }
        public double Rest { get; set; }
        [ForeignKey("SupplierBill")]
        public int SupplierBill_Id { get; set; }
        public SupplierBill SupplierBill { get; set; }
    }
}
