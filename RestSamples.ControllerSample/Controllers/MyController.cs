using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RestSamples.Model;

namespace RestSamples.ControllerSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ProductDbContext context;

        public MyController(ProductDbContext context)
        {
            this.context = context;
        }
        [HttpGet("Get1")]
        public string GetName()
        {
            return "Hi";
        }
        [HttpGet("Get2")]
        public string GetName2()
        {
            return "Hi2";
        }

        //[HttpPost]
        //public ViewResult AddUser()
        //{
        //    return "Hi2";
        //}


        //[HttpPost]
        //public NotFoundResult AddUser2()
        //{
        //    return "Hi2";
        //}

        [HttpPost]
        public IActionResult AddUser9([FromServices] ProductDbContext context)
        {
            return Ok();
        }

        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = context.Products.Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("GetProduct/{id}")]
        public async Task<IActionResult> GetProduct2(int id)
        {
            var product = context.Products.Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("{Google}")]
        public async Task<IActionResult> Redirect()
        {
            return Redirect("");
        }

        [HttpPatch("{id}")]
        public async Task<Product> PathProduct(long id , JsonPatchDocument<Product> patchDocument)
        {
            Product p = await context.Products.FindAsync(id);
            if (p != null)
            {
                patchDocument.ApplyTo(p);
                await context.SaveChangesAsync();
            }
            return p;
        }
    }
}















//[HttpGet("GetProduct/{id}")]
//public IActionResult GetProduct()
//{
//    return Ok();
//}