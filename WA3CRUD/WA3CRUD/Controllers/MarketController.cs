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
        private readonly IMarket phonemarket = new Market();


        [HttpGet("products")]
        public IEnumerable<Product> GetAllProducts()
        {
            return phonemarket.GetAll();
        }


        [HttpGet("products/{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProduct([FromRoute] string id)
        {
            Product item = phonemarket.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet("products/manufacturer")]
        public IEnumerable<Product> GetProductsByManufacturer([FromRoute] string company)
        {
            return phonemarket.GetAll().Where(p => string.Equals(p.ManufacturerOfProduct.CompanyName, company, StringComparison.OrdinalIgnoreCase));
        }

        [HttpPost("products/")]
        public Product PostProduct([FromQuery] Product item)
        {
            var itemnew = phonemarket.Add(item);
            return itemnew;
        }
                
        [HttpPut("products/{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PutProduct([FromRoute] string id, Product product)
        {
            product.ID = id;
            if (!phonemarket.Update(product))
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpDelete("products/{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteProduct([FromRoute] string id)
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
