using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.ViewComponents.UiLayoutComponents
{
    public class _UiLayoutPreloaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
