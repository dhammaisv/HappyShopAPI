using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyShopAPI.Models.DL
{
    public class ProductData
    {
        public string Name { get; set; }
        public bool SoldOut { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}