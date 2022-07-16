using Microsoft.AspNetCore.Http;
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
        public IActionResult AddUser9([FromServices]ProductDbContext context)
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
    }
}
















//[HttpGet("GetProduct/{id}")]
//public IActionResult GetProduct()
//{
//    return Ok();
//}