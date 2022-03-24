using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessAuto.Models;
using System.Collections.Generic;
using System.IO;

namespace ProcessAuto.Controllers
{
    public class ExcelController : Controller
    {
        // GET: ExcelController
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<ExcelModel>());
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            List<ExcelModel> users = new List<ExcelModel>();
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
                        users.Add(new ExcelModel
                        {
                            Name = reader.GetValue(0).ToString(),
                            Email = reader.GetValue(1).ToString(),
                            Password = reader.GetValue(2).ToString()
                        });
                    }
                }
            }
            return View(users);
        }

        // GET: ExcelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExcelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExcelController/Create
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

        // GET: ExcelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExcelController/Edit/5
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

        // GET: ExcelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExcelController/Delete/5
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
