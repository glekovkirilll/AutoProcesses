using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcessAuto.Data;
using ProcessAuto.Models;
using ProcessAuto.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
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

        [HttpGet("{userId}")]
        [Route("Vacancies/{userId}")]
        public async Task<IActionResult> ShowSomeVacancy(int userId)
        {
            //var student = await this._context.Users.SingleOrDefaultAsync(x => x.Id == studentId);
            var vacancy = _context.Vacancies.FirstOrDefault(x => x.Id == userId);
            this.ViewData["VacancyId"] = userId;
            var vacancyViewModel = new VacancyViewModel
            {
                Company = vacancy.Company,
                Stack = vacancy.Stack,
                Slots = vacancy.Slots,
                Position = vacancy.Position,
            };
            this.ViewData["Vacancy"] = vacancyViewModel;

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
    }
    
}
