using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View(); 
		}
	}
}
