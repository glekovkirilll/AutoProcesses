using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProcessAuto.Areas.Identity.Data;
using ProcessAuto.Models;

namespace ProcessAuto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<PAUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<PAUser> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null)
            {
                return RedirectToAction("Privacy", "Home");
            }
            else
            {
                PAUser user = _userManager.FindByIdAsync(userId).Result;
                return View(user);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Resume()
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
