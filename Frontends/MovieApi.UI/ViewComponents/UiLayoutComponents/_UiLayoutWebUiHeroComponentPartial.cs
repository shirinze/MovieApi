using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.ViewComponents.UiLayoutComponents
{
    public class _UiLayoutWebUiHeroComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
