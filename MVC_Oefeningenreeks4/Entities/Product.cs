﻿using System;
using System.Collections.Generic;

namespace MVC_Oefeningenreeks4.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }

        public Supplier Supplier { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
