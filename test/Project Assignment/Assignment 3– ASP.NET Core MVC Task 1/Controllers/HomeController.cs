using Assignment_3__ASP.NET_Core_MVC_Task_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_3__ASP.NET_Core_MVC_Task_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
