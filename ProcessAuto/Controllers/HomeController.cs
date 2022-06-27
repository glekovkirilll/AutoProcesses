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
        private readonly SignInManager<PAUser> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<PAUser> userManager, SignInManager<PAUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null)
            {
                return RedirectToAction("Privacy", "Home");
            }
            else
            {
                PAUser user1 = _userManager.FindByIdAsync(userId).Result;
                return View(user1);
            }

            
        }

        public async Task<IActionResult> Privacy()
        {
            var user = new PAUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                Name = "Admin",
                Surname = "#1",
                MiddleName = "!!!"
            };

            var result = await _userManager.CreateAsync(user, "123456qW!");
            if (result.Succeeded)
            {
                IdentityResult roleresult = await _userManager.AddToRoleAsync(user, "ADMIN");
            }

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
