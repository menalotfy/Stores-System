using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class Products
    {
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        [DataType("nvarch(50)")]

        public string ProductName { get; set; }
        public double Price_individual { get; set; }
        [Required]
        public double IncomePrice { get; set; }
        public double Price_customer { get; set; }//gomlh
        public double Discount { get; set; }
        public double quantityPerProducts { get; set; }//computed column to quantityPerGroup * // NumberOfProductInGroup
        public int quantityPerGroup { get; set; }
        [Required]
        public double NumberOfProductInGroup { get; set; }

        public bool status { get; set; }
        [ForeignKey("categories")]
        public int? categories_id { get; set; }
        public Categories categories { get; set; }

        [ForeignKey("ProductUnit")]
        public int? ProductUnit_id { get; set; }

        public ProductUnits ProductUnit { get; set; }
        [ForeignKey("Supplier")]
        public int? supplier_id { get; set; }

        public Suppliers Supplier { get; set; } 
    }
}
