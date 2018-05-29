using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Oefeningenreeks4.Entities;
using MVC_Oefeningenreeks4.Repositories;

namespace MVC_Oefeningenreeks4.Controllers
{
    [Produces("application/json")]
    [Route("api/products")]
    public class OrderController : Controller
    {
        private ProductRepository ProductRepo;

        public OrderController(ProductRepository productRepository)
        {
            ProductRepo = productRepository;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                List<Product> producten = ProductRepo.GetAllProducts();
                return Ok(producten);
            }catch(Exception e)
            {
                return BadRequest($"Something went wrong: {e.Message}");
            }
        }
    }
}