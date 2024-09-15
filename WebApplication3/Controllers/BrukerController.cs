using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class BrukerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
