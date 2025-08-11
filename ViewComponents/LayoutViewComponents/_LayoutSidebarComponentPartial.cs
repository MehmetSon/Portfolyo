using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial  :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
