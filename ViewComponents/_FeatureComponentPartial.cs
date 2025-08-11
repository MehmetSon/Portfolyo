using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();    
            return View(values);
        }
    }
}
