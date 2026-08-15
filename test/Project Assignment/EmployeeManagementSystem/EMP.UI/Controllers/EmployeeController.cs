using Microsoft.AspNetCore.Mvc;


namespace EMP.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
