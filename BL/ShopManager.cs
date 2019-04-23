using HappyShopAPI.DL;
using HappyShopAPI.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyShopAPI.BL
{
    public class ShopManager : IShopManager
    {
        private IDataHandler DataHandler { get; set; }
        public ShopManager(IDataHandler dataHandler)
        {
            this.DataHandler = dataHandler;
        }

        public IList<ProductInfo> GetProducts(ProductInputParameter parmeter)
        {
            return null;
        }

        public bool IsValidCategory(string[] category)
        {
            throw new NotImplementedException();
        }
    }
}