using HappyShopAPI.BL;
using HappyShopAPI.DL;
using HappyShopAPI.Models.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HappyShopAPI.Controllers
{
    public class APIController : ApiController
    {
        private IShopManager ShopManager { get; set; }
        public APIController()
        {
            ShopManager = new ShopManager(new DataHandler());
        }

        [HttpGet]
        [Route("product")]
        public IHttpActionResult GetProducts([FromUri] ProductInputParameter parmeter)
        {
            // validate category parameter
            if (parmeter.CategoryArray != null && !ShopManager.IsValidCategory(parmeter.CategoryArray))
            {
                return BadRequest("invalid category");
            }

            // validate sorting parameter
            if (!string.IsNullOrEmpty(parmeter.Sorting) && (parmeter.Sorting != "asc" || parmeter.Sorting != "desc"))
            {
                return BadRequest("invalid sorting parameter (should be asc or desc)");
            }

            var result = ShopManager.GetProducts(parmeter);

            return Ok(result);
        }
    }
}
