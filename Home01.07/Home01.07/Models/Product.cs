using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home01._07.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price {  get; set; }
        public int PriceOld { get; set;}
    }
}