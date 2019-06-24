using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class Orders
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalCost { get; set; }
        [ForeignKey("SalesRepresentative")]
        public int SalesRepresentative_Id { get; set; }

        public SalesRepresentative SalesRepresentative { get; set; }
        public bool status { get; set; }

    }
        public class OrderDetails
        {
            public int ID { get; set; }
            [ForeignKey("products")]
            public int products_id { get; set; }
            public Products products { get; set; }
            public int quantity { get; set; }
            [ForeignKey("Order")]
            public int Order_id { get; set; }
            public Orders Order { get; set; }

        }




    }

