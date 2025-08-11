using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _ContactComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke() {
            return View(); 
        }
    }
}
