using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View();
        }
    }
}
