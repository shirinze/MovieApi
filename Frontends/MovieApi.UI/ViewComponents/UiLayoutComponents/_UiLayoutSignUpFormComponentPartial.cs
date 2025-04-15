using Microsoft.AspNetCore.Mvc;

namespace MovieApi.UI.ViewComponents.UiLayoutComponents
{
    public class _UiLayoutSignUpFormComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
