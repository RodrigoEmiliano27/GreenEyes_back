using Microsoft.AspNetCore.Mvc;

namespace Green_eyes_server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
