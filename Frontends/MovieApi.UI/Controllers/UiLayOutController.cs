using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.Controllers
{
    public class UiLayOutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
