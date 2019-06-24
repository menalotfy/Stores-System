using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasPrice { get; set; }
        public double CustomerRest { get; set; }
        public string Phone { get; set; }
        public string addrees { get; set; }
        public string type { get; set; }
        public bool Status { get; set; }
                                           //        public ICollection<GeneralBill> generalBills { get; set; }
                                           //      public ICollection<GeneralBill> generalBills { get; set; }

    }
}
