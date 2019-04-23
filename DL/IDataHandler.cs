using HappyShopAPI.Models.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyShopAPI.DL
{
    public interface IDataHandler
    {
        IList<ProductData> GetProductData();
    }
}
