using Microsoft.AspNetCore.Mvc;
namespace test01.Controllers
{
    public class MoviesController : Controller
    {
        #region Action Types
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
        //public IActionResult Index()
        //{
        //    return Content("Batman");
        //}

        //public IActionResult Redirect()
        //{
        //    return RedirectToAction("Index");
        //}

        #endregion
        #region Action Parameter
        //public IActionResult Index() 
        //{ 
        //    return Content("Hello From Movies"); 
        //}
        //public IActionResult GetMovie(int id , string name)
        //{
        //    //1. Send the data from form
        //    //2. Send the data via Sigment of URL
        //    //3. Send the data via Query
        //    return Content($"Movie :  {id} | Name : {name}");
        //}
        #endregion


    }
}
