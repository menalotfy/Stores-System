using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
   public class GeneralBillPayment
    {

        public int ID { get; set; }
        public double Paied { get; set; }
        public double Rest { get; set; }
        [ForeignKey("generalBill")]
        public int generalBill_Id { get; set; }
        public GeneralBill generalBill { get; set; }
    }
}
