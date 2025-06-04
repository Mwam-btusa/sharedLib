using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shared.Lib.Models;
using sharedLib.MVC.Models;

namespace sharedLib.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
        [HttpPost]
        public IActionResult ProcessData(int id, string name)
        {
            SharedData data = new SharedData(); 
            data.Id = id;
            data.Name = name;

            return View(data);

        }
     }

}
