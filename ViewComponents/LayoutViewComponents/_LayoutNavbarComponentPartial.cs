using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke() 
		{  
			ViewBag.ToDoListCount = portfolioContext.ToDoLists.Where(x=>x.Status==true).Count();
			var value = portfolioContext.ToDoLists.Where(x=>x.Status==true).ToList();
			return View(value); 
		}
	}
}
