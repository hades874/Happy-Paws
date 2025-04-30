using Microsoft.AspNetCore.Mvc;

namespace HappyPaws.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
