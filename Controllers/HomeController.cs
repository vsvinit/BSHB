using BiharStateHousingBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BiharStateHousingBoard.Controllers
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
        public PartialViewResult HomePopUP()
        {
            return PartialView("_HomePopUP");
        }
        //public PartialViewResult Index()
        //{
        //    //return View
        //    return PartialView("_HomePopUP");

        //}
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