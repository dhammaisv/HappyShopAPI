using HappyShopAPI.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyShopAPI.BL
{
    public interface IShopManager
    {
        IList<ProductInfo> GetProducts(ProductInputParameter parmeter);
        bool IsValidCategory(string[] category);
    }
}
