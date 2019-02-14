using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DeliveryService.Models;

namespace DeliveryService.Controllers
{
    public class ProductController : ApiController
    {
        /// <summary>
        /// Lista todos os produtos.
        /// </summary>
        /// <returns></returns>
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                var productDto = new List<Product>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
