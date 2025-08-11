using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;

namespace Portfolyo.Controllers
{
	public class MailController : Controller
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values = portfolioContext.Messages.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = portfolioContext.Messages.Find(id);
			value.IsRead = true;
			portfolioContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = portfolioContext.Messages.Find(id);
			value.IsRead = false;
			portfolioContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult DeleteMail(int id)
		{
			var value = portfolioContext.Messages.Find(id);
			portfolioContext.Messages.Remove(value);
			portfolioContext.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MailDetails(int id) 
		{
			var value = portfolioContext.Messages.Find(id); 
			return View(value);
		}

	}
}
