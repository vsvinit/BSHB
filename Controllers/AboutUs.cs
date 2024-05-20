using Microsoft.AspNetCore.Mvc;

namespace BiharStateHousingBoard.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
