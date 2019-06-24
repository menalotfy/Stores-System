using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class Suppliers
    {
        public int ID { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        public string CompanyRepresentative { get; set; }
        [RegularExpression(pattern: @"\w{0,11}")]
        public string SupplierPhone { get; set; }
        public string Address { get; set; }
        public bool status { get; set; }
        public virtual ICollection<Products> Products { get; set; }

        public virtual ICollection<SupplierBill> SupplierBills { get; set; }
    }
}
