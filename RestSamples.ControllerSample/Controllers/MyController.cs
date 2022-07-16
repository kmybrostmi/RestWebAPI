using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestSamples.ControllerSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
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
        public IActionResult AddUser9()
        {
            return Ok();
        }
    }
}

