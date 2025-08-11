using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        }
    }
}
