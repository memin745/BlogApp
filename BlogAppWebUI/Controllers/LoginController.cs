using BlogApp.DataAccesLayer.Concrete;
using BlogApp.EntitityLayer.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogAppWebUI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            BloggAppContext appContext = new BloggAppContext();
            var userinfo = appContext.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail && x.UserPassword == user.UserPassword);

            if (userinfo != null)
            {
                // Kullanıcı doğrulandı, oturum başlat
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, userinfo.UserName),
            new Claim(ClaimTypes.Email, userinfo.UserEmail),
            // İhtiyaç duyarsanız ekstra claim'leri ekleyebilirsiniz.
        };

                var identity = new ClaimsIdentity(claims, "cookie");

                var principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(principal);

                // Kullanıcıyı Category/Index sayfasına yönlendir
                return RedirectToAction("Index", "Article");
            }
            else
            {
                // Kullanıcı doğrulanamadı, giriş sayfasına yönlendir
                return RedirectToAction("Index");
            }
        }

        // Çıkış işlemi için
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();

            return RedirectToAction("Index");
        }

    }
}
