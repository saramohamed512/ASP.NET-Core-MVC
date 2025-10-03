using Microsoft.AspNetCore.Mvc;

namespace test01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View(new MoviesController());
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
