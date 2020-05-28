using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSYTASP.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSYTASP.Model;

namespace MSYTASP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService _productService;
        public ProductsController(JsonFileProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Patch(string productId, int rating)
        {
            _productService.AddRating(productId, rating);
            return Ok();
        }
    }
}