using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessAuto.Models;
using System.Collections.Generic;

namespace ProcessAuto.Controllers
{
    public class StudentsRegistrationController : Controller
    {
        // GET: StudentsRegistrationController
        [HttpGet]
        public ActionResult Index()
        {
            return View(new List<Student>());
        }

        // GET: StudentsRegistrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

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
