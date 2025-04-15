using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.ViewComponents.UiLayoutComponents
{
    public class _UiLayoutLoginFormComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
