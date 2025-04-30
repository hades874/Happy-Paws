using Microsoft.AspNetCore.Mvc;

namespace HappyPaws.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addEmplyee()
        {
            return View();
        }

        public IActionResult petStay()
        {
            return View();
        }

        public IActionResult petAdopt()
        {
            return View();
        }

        public IActionResult vet()
        {
            return View();
        }
    }
}
