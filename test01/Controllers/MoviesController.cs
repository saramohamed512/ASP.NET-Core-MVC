using Microsoft.AspNetCore.Mvc;
namespace test01.Controllers
{
    public class MoviesController : Controller
    {
        //Must Be Public Non Static Method => action

        public string Index()
        {
            return "MoviesIndex";
        }
        public void GetMovies() 
        {

        }
    }
}
