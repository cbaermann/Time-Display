using Microsoft.AspNetCore.Mvc;

namespace timeDisplay.Controllers
{
    public class HelloController: Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}