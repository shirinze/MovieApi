using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.ViewComponents.UiLayoutComponents
{
    public class _UiLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
