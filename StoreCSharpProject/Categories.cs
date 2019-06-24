using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class Categories
    {
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        [DataType(DataType.Text)]

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Products> products { get; set; } = new List<Products>();

    }
}
