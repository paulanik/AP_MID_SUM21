﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace _4_tier_webapi.Controllers
{
    public class FProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
        [Route("api/Product/All/Details")]
        public List<ProductDetails> GetAllProducts()
        {
            return ProductService.GetAllProducts();
        }
        [Route("api/Product/Types/Details")]
        public List<Product_TypeDetails> GetProductTypeDetails()
        {
            return ProductService.GetProductTypeDetails();
        }
        [Route("api/Product/Types/All")]
        public List<Product_TypeModel> GetAllProductType()
        {
            return ProductService.GetAllProductType();
        }
    }
}
