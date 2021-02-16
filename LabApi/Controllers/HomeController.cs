using Microsoft.AspNetCore.Mvc;

namespace LabApi.Controllers
{
    public class HomeController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return Json(new { 
                Mesage = "HI",
                IsHttps = Request.IsHttps
            });
        }
    }
}
