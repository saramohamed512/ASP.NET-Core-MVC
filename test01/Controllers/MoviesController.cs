using Microsoft.AspNetCore.Mvc;
namespace test01.Controllers
{
    public class MoviesController : Controller
    {
        //Must Be Public Non Static Method => action
        //Action => Return Data To Web App
        //public ContentResult Index()
        //{
        //    var Result = new ContentResult();
        //    Result.Content = "Black";
        //    return Result;
        //}

        //public RedirectResult Redirect()
        //{
        //    var Result = new RedirectResult("https://www.google.com");
        //    return Result;
        //}
        public IActionResult Index()
        {
            return Content("Batman");
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

    }
}
