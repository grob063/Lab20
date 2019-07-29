using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab20EFCore.GenesCoffee
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public User user { get; set; }
    }
}
