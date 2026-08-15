using Assignment_3__ASP.NET_Core_MVC_Task_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_3__ASP.NET_Core_MVC_Task_1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
        public IActionResult Service()
        {
            // Create List<ServiceModel>

            List<ServiceModel> serviceList = new List<ServiceModel>();

            // Add Service Records

            serviceList.Add(new ServiceModel
            {
                Id = 1,
                Title = "Web Development",
                Description = "Build responsive and dynamic websites using ASP.NET Core MVC."
            });

            serviceList.Add(new ServiceModel
            {
                Id = 2,
                Title = "Mobile Application Development",
                Description = "Develop Android applications using Kotlin."
            });

            serviceList.Add(new ServiceModel
            {
                Id = 3,
                Title = "Database Management",
                Description = "Design and maintain MySQL databases."
            });

            serviceList.Add(new ServiceModel
            {
                Id = 4,
                Title = "Cloud Services",
                Description = "Deploy applications on cloud platforms."
            });

            serviceList.Add(new ServiceModel
            {
                Id = 5,
                Title = "Technical Support",
                Description = "Provide maintenance and software support."
            });


            return View(serviceList);
        }

    }
}
