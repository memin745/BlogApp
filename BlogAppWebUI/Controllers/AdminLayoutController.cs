using Microsoft.AspNetCore.Mvc;

namespace BlogAppWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
