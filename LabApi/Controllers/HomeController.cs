using Microsoft.AspNetCore.Mvc;

namespace LabApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Json(new { 
                Mesage = "HI",
                IsHttps = Request.IsHttps
            });
        }
    }
}
