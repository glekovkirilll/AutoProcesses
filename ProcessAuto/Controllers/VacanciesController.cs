using Microsoft.AspNetCore.Mvc;
using ProcessAuto.Data;
using ProcessAuto.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAuto.Controllers
{
    [Route("Vacancies")]
    public class VacanciesController : Controller
    {

        private readonly ApplicationDbContext _context;        

        public VacanciesController(ApplicationDbContext context)
        {
            _context = context;            
        }

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
            return View();
        }
    }
    
}
