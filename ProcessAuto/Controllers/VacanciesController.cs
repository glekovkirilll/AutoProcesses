using Microsoft.AspNetCore.Mvc;
using ProcessAuto.Data;
using ProcessAuto.Models.ViewModels;
using ProcessAuto.Models;
using ProcessAuto.Models.Enums;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProcessAuto.Controllers
{
    //[Route("Vacancies")]
    public class VacanciesController : Controller
    {

        private readonly ApplicationDbContext _context;        

        public VacanciesController(ApplicationDbContext context)
        {
            _context = context;            
        }

        [HttpGet]
        [Route("Vacancies")]
        public IActionResult Index()
        {
            //var student = await this._context.Users.SingleOrDefaultAsync(x => x.Id == studentId);
            var vacancies = _context.Vacancies.Select(x => new VacancyViewModel
            {
                Id = x.Id,
                Company = x.Company,
                Position = x.Position,
                Slots = x.Slots,
                Stack = x.Stack
            });
            this.ViewData["Vacancies"] = vacancies;
            return View();
        }

        // GET: Companies/Create
        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Docs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Vacancies/Create")]

        public async Task<IActionResult> Create(VacancyViewModel model)
        {
            var Email = User.Identity.Name;
            var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == Email);
            if (ModelState.IsValid)
            {
                var vacancy = new Vacancy
                {
                    Company = ((CompanyNames)currentUser.Company).ToString(),
                    Stack = model.Stack,
                    Slots = model.Slots,
                    Position = model.Position
                };

                this._context.Add(vacancy);
                await this._context.SaveChangesAsync();
                return this.RedirectToAction("Index");
            }

            return this.View(model);
        }

        [Route("{userId}")]
        [HttpGet("Vacancies/{userId}")]        
        public async Task<IActionResult> ShowSomeVacancy(int userId)
        {
            //var student = await this._context.Users.SingleOrDefaultAsync(x => x.Id == studentId);
            var vacancy = _context.Vacancies.FirstOrDefault(x => x.Id == userId);
            var vacancyViewModel = new VacancyViewModel
            {
                Company = vacancy.Company,
                Stack = vacancy.Stack,
                Slots = vacancy.Slots,
                Position = vacancy.Position,
            };

            this.ViewData["Vacancy"] = vacancyViewModel;
            this.ViewData["VacancyId"] = userId;

            var student = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            var checkIfAlreadyResponded = await _context.Responds.FirstOrDefaultAsync(x => x.vacancy == vacancy && x.student == student);

            if (checkIfAlreadyResponded == default)
            {
                this.ViewData["checkIfAlreadyResponded"] = 0;
            }
            else
            {
                this.ViewData["checkIfAlreadyResponded"] = 1;
            }

            this.ViewBag.Id = vacancy.Id;
            return View();
        }

        [HttpGet("{vacId}")]
        [Route("Vacancies/RespondOnVacancy/{vacId}")]
        public async Task<IActionResult> RespondOnVacancy(int vacId)
        {
            var curUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == User.Identity.Name);
            var vacancyId = vacId;
            var respond = new VacancyUser
            {
                student = curUser,
                vacancy = await _context.Vacancies.FirstOrDefaultAsync(x => x.Id == vacancyId)
            };
            _context.Responds.Add(respond);
            await _context.SaveChangesAsync();
            return RedirectToAction("ShowSomeVacancy", "Vacancies", new { userId = vacancyId });
        }

        [HttpGet("{vacId}")]
        [Route("Vacancies/ShowVacancyResponds/{vacId}")]
        public async Task<IActionResult> ShowVacancyResponds(int vacId)
        {
            var curVacancy = await _context.Vacancies.FirstOrDefaultAsync(x => x.Id == vacId);
            var responders = _context.Responds.Where(x => x.vacancy == curVacancy).Include(y => y.student);

            List<VacancyRespond> responds = new List<VacancyRespond>();


            foreach (var r in responders)
            {
                var curStudent = r.student;
                var curStudentResume = await _context.Resumes.FirstOrDefaultAsync(x => x.student == curStudent);

                responds.Add(new VacancyRespond
                {
                    Email = curStudent.Email,

                    WorkingExperience = curStudentResume.WorkingExperience,
                    AboutYourself = curStudentResume.AboutYourself,
                    Stack = curStudentResume.Stack,
                    ProgrammingLanguages = curStudentResume.ProgrammingLanguages,
                    Hobbies = curStudentResume.Hobbies
                });
            }

            this.ViewData["Responds"] = responds;
            this.ViewData["VacId"] = vacId;

            return View();
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vacancy = await _context.Vacancies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vacancy == null)
            {
                return NotFound();
            }


            _context.Vacancies.Remove(vacancy);
            await _context.SaveChangesAsync();
            return this.RedirectToAction("Index");
        }

        //// GET: Companies/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Vacancies
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(company);
        //}

        //// POST: Companies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var vacancy = await _context.Vacancies.FindAsync(id);
        //    _context.Vacancies.Remove(vacancy);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
    
}
