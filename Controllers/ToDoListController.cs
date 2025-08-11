using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
		public IActionResult Index()
		{
			var value = myPortfolioContext.ToDoLists.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList) {
			toDoList.Status = true;
			myPortfolioContext.ToDoLists.Add(toDoList);
			myPortfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteToDoList(int id)
		{
			var value=myPortfolioContext.ToDoLists.Find(id);
			myPortfolioContext.ToDoLists.Remove(value);
			myPortfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value = myPortfolioContext.ToDoLists.Find(id);
			return View(value);	
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			myPortfolioContext.ToDoLists.Update(toDoList);
			myPortfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeToDoListStatusToTrue(int id)
		{
			var value = myPortfolioContext.ToDoLists.Find(id);
			value.Status = true;
			myPortfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeToDoListStatusToFalse(int id)
		{
			var value = myPortfolioContext.ToDoLists.Find(id);
			value.Status = false;
			myPortfolioContext.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
