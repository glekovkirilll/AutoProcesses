using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProcessAuto.Areas.Identity.Data;
using ProcessAuto.Models;
using ProcessAuto.Models.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ProcessAuto.Controllers
{
    public class HRRegistrationController : Controller
    {
        private readonly UserManager<PAUser> _userManager;
        private readonly SignInManager<PAUser> _signInManager;
        List<HumanResources> HR = new List<HumanResources>();

        public HRRegistrationController(UserManager<PAUser> userManager, SignInManager<PAUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        // GET: StudentsRegistrationController
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<HumanResources>());
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(IFormCollection form)
        {

            var fileName = "./Companies.xlsx";
            // For .net core, the next line requires the NuGet package, 
            // System.Text.Encoding.CodePages
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    while (reader.Read()) //Each row of the file
                    {
                        HR.Add(new HumanResources
                        {
                            Surname = reader.GetValue(0).ToString(),
                            Name = reader.GetValue(1).ToString(),                          
                            MiddleName = reader.GetValue(2).ToString(),
                            Email = reader.GetValue(3).ToString(),
                            Password = "123456qW!",
                            Company = Int32.Parse(reader.GetValue(4).ToString())
                            
                        });
                    }
                }
            }

            foreach (var hr in HR)
            {
                var user = new PAUser { UserName = hr.Email, 
                                        Email = hr.Email,                                         
                                        EmailConfirmed = true, 
                                        Company = hr.Company,
                                        Name = hr.Name,
                                        Surname = hr.Surname,
                                        MiddleName = hr.MiddleName};

                var result = await _userManager.CreateAsync(user, hr.Password);
                if(result.Succeeded)
                {
                    IdentityResult roleresult = await _userManager.AddToRoleAsync(user, "COMPANY");
                }
            }
            return View(HR);
        }
    }
}
