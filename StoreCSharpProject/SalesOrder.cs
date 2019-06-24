using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class SalesOrder
    {
        public int ID { get; set; }
        public DateTime SalesOrderDate { get; set; }
        public double SalesOrederTotalPrice { get; set; }
        public bool status { get; set; }

        //  public Returned Returned { get; set; }
        //[ForeignKey("salesRepresentative")]
        //public int salesRepresentative_Id { get; set; }

         [ForeignKey("SalesRepresentative")]
         public int? SalesRepresentative_id { get; set; }
        [ForeignKey("customers")]
        public int? customers_Id { get; set; }
        public Customers customers { get; set; }

      public   SalesRepresentative SalesRepresentative { get; set; }
        public ICollection<SalesOrderDetails> SalesOrderDetails { get; set; }
        public ICollection<SalesOredersPaymment> salesOredersPaymments { get; set; }

    }
}
