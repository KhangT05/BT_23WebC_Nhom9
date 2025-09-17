using System.Diagnostics;
using baitap_nhom.Models;
using Microsoft.AspNetCore.Mvc;

namespace baitap_nhom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Khang
        private readonly UserDIManager _usersDI;
        public HomeController(ILogger<HomeController> logger, UserDIManager usersDI)
        {
            _logger = logger;
            _usersDI = usersDI;
        }

        public IActionResult Index()
        {
            var users = _usersDI.GetAll();
            return View(users);
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
