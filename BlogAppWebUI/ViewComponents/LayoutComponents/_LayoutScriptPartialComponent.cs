using Microsoft.AspNetCore.Mvc;

namespace BlogAppWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
