using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WA3CRUD.Models;

namespace WA3CRUD.Controllers
{
    [Route("api")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        static readonly IMarketable phonemarket = new Market();


        [HttpGet("Products")]
        public IEnumerable<Product> GetAllProducts()
        {
            return phonemarket.GetAll();
        }


        [HttpGet("Products/id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProduct(int id)
        {
            Product item = phonemarket.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }


        /*          
        NOT WORKING variant
                  
        [HttpGet("Products/id")]
        public Product GetProduct(int id)
        {
            Product item = phonemarket.Get(id);
            if (item == null)
            {
                GetProductError();
            }
            return item;
        }

        [Route("Products/id")]
        [HttpPost]
        public IActionResult GetProductError()
        {
            return NotFound();
        }
        */

        [HttpGet("Products/Manufacturer")]
        public IEnumerable<Product> GetProductsByManufacturer(string company)
        {
            return phonemarket.GetAll().Where(p => string.Equals(p.ManufacturerOfProduct.CompanyName, company, StringComparison.OrdinalIgnoreCase));
        }


        [HttpPost("Products/Add")]
        public Product PostProduct(Product item)
        {
            item = phonemarket.Add(item);
            return item;
        }

        /* 
            NOT WORKING variant from learn.microsoft.com: CreateResponse always gives an error message Compiler Error CS1061 - missing a using directive, 
                                                          but VS do not suggest to add any new using
           
            using System.Net;
            using System.Net.Http;
          
            public HttpResponseMessage PostProduct(Product item)
        {
            item = phonemarket.Add(item);
            var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }
        */

        [HttpPut("Products/new")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PutProduct(int id, Product product)
        {
            product.ID = id;
            if (!phonemarket.Update(product))
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpDelete("Products/delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteProduct(int id)
        {
            Product item = phonemarket.Get(id);
            if (item == null)
            {
                return NotFound();
            }

            phonemarket.Remove(id);
            return Ok();
        }

    }
}
