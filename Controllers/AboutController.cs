using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
		public IActionResult Index()
		{
			var value = myPortfolioContext.Abouts.FirstOrDefault();
			return View(value);
		}
		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var value = myPortfolioContext.Abouts.Find(id);
			return View(value);
		}
		[HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            myPortfolioContext.Abouts.Update(about);
            myPortfolioContext.SaveChanges();
			return RedirectToAction("Index");
        }
    }
}
