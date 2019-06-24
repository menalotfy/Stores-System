using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    class Returned
    {
        public int ID { get; set; }
        //public ICossllection<SalesOrder> SalesOrder { get; set; }

        //   public int salesOrderId { get; set; }
        [ForeignKey("GeneralBill")]
        public int GeneralBillId { get; set; }
        public virtual GeneralBill GeneralBill { get; set; } //for edit in any bill
        [ForeignKey("SalesOrder")]
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; } //for edit in any bill
    }
}
