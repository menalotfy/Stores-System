using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class SalesRepresentative
    {
        public int ID { get; set; }
        public double? Bonus { get; set; }
        [ForeignKey("Employee")]
        public int Employee_Id { get; set; }
        public Employee Employee { get; set; }
        public bool status { get; set; }
        public ICollection<Orders>Orders { get; set; }
        public ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
