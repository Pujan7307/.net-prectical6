using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCatalog.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}