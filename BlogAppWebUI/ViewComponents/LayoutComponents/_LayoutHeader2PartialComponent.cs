using Microsoft.AspNetCore.Mvc;

namespace BlogAppWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutHeader2PartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
