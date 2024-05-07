using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Areas.indexorxan.Controllers
{

    [Area("indexorxan")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
