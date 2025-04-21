using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            ViewBag.v1 = "Movie";
            ViewBag.v2 = "Home";
            ViewBag.v3 = "MovieList";

            return View();
        }
    }
}
