using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyShopAPI.Models.BL
{
    public class ProductInputParameter
    {
        public string[] CategoryArray { get; set; }
        public PriceRange[] PriceRangeArray { get; set; }
        public string Sorting { get; set; }
        public int PageNumber { get; set; }
        public int MaxRowsInPage { get; set; }
        public class PriceRange
        {
            public int MinPrice { get; set; }
            public int MaxPrice { get; set; }
        }
    }
}