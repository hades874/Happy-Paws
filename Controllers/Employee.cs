using Microsoft.AspNetCore.Mvc;

namespace HappyPaws.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
