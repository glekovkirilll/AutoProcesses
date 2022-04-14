using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProcessAuto.Areas.Identity.Data;
using ProcessAuto.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ProcessAuto.Controllers
{
    public class CompaniesRegistrationController : Controller
    {
        private readonly UserManager<PAUser> _userManager;
        private readonly SignInManager<PAUser> _signInManager;
        List<Company> companies = new List<Company>();

        public CompaniesRegistrationController(UserManager<PAUser> userManager, SignInManager<PAUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        // GET: StudentsRegistrationController
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<Company>());
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
                        companies.Add(new Company
                        {                           
                            Name = reader.GetValue(0).ToString(),                            
                            Email = reader.GetValue(1).ToString(),
                            Password = reader.GetValue(2).ToString()
                        });
                    }
                }
            }

            foreach (var Student in companies)
            {
                var user = new PAUser { UserName = Student.Email, 
                                        Email = Student.Email, 
                                        EmailConfirmed = true, 
                                        Name = Student.Name};

                var result = await _userManager.CreateAsync(user, Student.Password);
                if(result.Succeeded)
                {
                    IdentityResult roleresult = await _userManager.AddToRoleAsync(user, "COMPANY");
                }
            }
            return View(companies);
        }
    }
}
