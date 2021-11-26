using Microsoft.AspNetCore.Mvc;

namespace bun_ex1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
