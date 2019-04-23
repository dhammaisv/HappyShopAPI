using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HappyShopAPI.Models.BL
{
    [DataContract]
    public class ProductInfo
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "sold_out")]
        public bool SoldOut { get; set; }
        [DataMember(Name = "category")]
        public string Category { get; set; }
        [DataMember(Name = "price")]
        public int Price { get; set; }
    }
}