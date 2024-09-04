using FirstResponsiveWebAppTurner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppTurner.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Birthday Calculator";
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponsiveWebAppModel model)
        {
            ViewBag.BirthYear = model.AgeThisYear();
            return View(model);
        }
    }
}
