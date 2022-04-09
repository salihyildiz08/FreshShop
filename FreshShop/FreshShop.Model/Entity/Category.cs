﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.Model.Entity
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
