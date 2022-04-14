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
    public class StudentsRegistrationController : Controller
    {
        private readonly UserManager<PAUser> _userManager;
        private readonly SignInManager<PAUser> _signInManager;
        List<Student> students = new List<Student>();

        public StudentsRegistrationController(UserManager<PAUser> userManager, SignInManager<PAUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        // GET: StudentsRegistrationController
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<Student>());
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(IFormCollection form)
        {

            var fileName = "./Users.xlsx";
            // For .net core, the next line requires the NuGet package, 
            // System.Text.Encoding.CodePages
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    while (reader.Read()) //Each row of the file
                    {
                        students.Add(new Student
                        {
                            Surname = reader.GetValue(0).ToString(),
                            Name = reader.GetValue(1).ToString(),
                            MiddleName = reader.GetValue(2).ToString(),
                            Email = reader.GetValue(3).ToString(),
                            Password = reader.GetValue(4).ToString()
                        });
                    }
                }
            }

            foreach (var Student in students)
            {
                var user = new PAUser { UserName = Student.Email, 
                                        Email = Student.Email, 
                                        EmailConfirmed = true, 
                                        Name = Student.Name, 
                                        Surname = Student.Surname, 
                                        MiddleName = Student.MiddleName };

                var result = await _userManager.CreateAsync(user, Student.Password);
                if(result.Succeeded)
                {
                    IdentityResult roleresult = await _userManager.AddToRoleAsync(user, "STUDENT");
                }
            }
            return View(students);
        }
        //[HttpGet]
        //public async Task<IActionResult> Register()
        //{
        //    return View(students);
        //}
        ////GET: StudentsRegistrationController/Details/5
        //[HttpPost]
        //public async Task<IActionResult> Register(List<Student> studentsToAdd)
        //{
        //    foreach (var Student in studentsToAdd) 
        //    { 
        //        PAUser user = new PAUser { Surname = Student.Surname, Name = Student.Name, MiddleName = Student.MiddleName, Email = Student.Email};
        //        var result = await _userManager.CreateAsync(user, Student.Password);
        //    }


        //    return View(students);
        //}

        // GET: StudentsRegistrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsRegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsRegistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentsRegistrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsRegistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentsRegistrationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
