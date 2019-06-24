using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class GeneralBillDetails
    {
        public int ID { get; set; }

        public int Quantity { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public Products Product { get; set; }

        [ForeignKey("GeneralBill")]
        public int generalBill_Id { get; set; }
        public GeneralBill GeneralBill { get; set; }
    }
}
