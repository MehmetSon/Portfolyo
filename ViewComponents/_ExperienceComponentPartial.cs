using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
