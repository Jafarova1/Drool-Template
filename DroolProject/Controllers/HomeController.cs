using Microsoft.AspNetCore.Mvc;

namespace DroolProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
