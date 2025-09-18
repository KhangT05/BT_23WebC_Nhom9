using System.Diagnostics;
using baitap_nhom.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace baitap_nhom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserDIManager _userManager;
        public HomeController(ILogger<HomeController> logger, UserDIManager userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            var users = _userManager.GetAll();
            var pagedUsers = users.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling(users.Count / (double)pageSize);

            return View(pagedUsers);
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
