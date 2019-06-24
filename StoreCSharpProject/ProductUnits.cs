﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
  public  class ProductUnits
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Products> products { get; set; }
    }
}
