﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Entities
{
    public class Product
    {
        public int PrductId { get; set; }
        public string  Name { get; set; }
        public string  Description { get; set; }
        public decimal Price { get; set; }
        public string  Category { get; set; }

    }
}
