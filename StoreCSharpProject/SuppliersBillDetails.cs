using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
   public class SuppliersBillDetails
    {

        public int ID { get; set; }
        //public string ProductCategory { get; set; }
        //public double ProductPrice { get; set; }
        //public double Discount { get; set; }
        [ForeignKey("products")]
        public int products_Id { get; set; }

        public Products products { get; set; }
        public int quantity { get; set; }
        [ForeignKey("SupplierBill")]
        public int SupplierBill_Id { get; set; }
        public SupplierBill SupplierBill { get; set; }
    }
}
