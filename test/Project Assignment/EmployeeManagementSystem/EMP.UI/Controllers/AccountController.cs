using Microsoft.AspNetCore.Mvc;

namespace EMP.UI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                HttpContext.Session.SetString("Username", username);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password.";

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}
