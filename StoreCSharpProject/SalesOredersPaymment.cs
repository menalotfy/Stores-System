using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class SalesOredersPaymment
    {
        public int ID { get; set; }
        public double Paied { get; set; }
        public double Rest { get; set; }
        public bool status { get; set; }

        [ForeignKey("SalesOrder")]
        public int SalesOrder_id { get; set; }
        public SalesOrder SalesOrder { get; set; }
       
    }
}
