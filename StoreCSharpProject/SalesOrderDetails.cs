using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
   public class SalesOrderDetails
    {

        public int ID { get; set; }
        [ForeignKey("products")]
        public int products_id { get; set; }
        public Products products { get; set; }
        public int quantity { get; set; }
        [ForeignKey("salesOrder")]
        public int salesOrder_id { get; set; }
        public SalesOrder salesOrder { get; set; }
    }
}
