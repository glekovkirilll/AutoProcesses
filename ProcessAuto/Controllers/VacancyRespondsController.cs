using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcessAuto.Data;
using System;
using System.Threading.Tasks;
using ProcessAuto.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;

namespace ProcessAuto.Controllers
{
    public class VacancyRespondsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VacancyRespondsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("VacancyResponds/AssignInterview/{respondId}")]
        public async Task<IActionResult> AssignInterview(int respondId, int vacId)
        {
            var model = new AssignInverviewViewModel { respondId = respondId };
            model.vacId = vacId;
            return View(model);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AssignInterview(AssignInverviewViewModel model)
        {
            var respond = await _context.Responds.FirstOrDefaultAsync(x => x.Id == model.respondId);

            if (respond == null)
                return NotFound("No such respond");

            var dateArray = model.InterviewDate.ToCharArray();
            var newDateArray = model.InterviewDate.ToCharArray();
            newDateArray[0] = dateArray[3];
            newDateArray[1] = dateArray[4];
            newDateArray[3] = dateArray[0];
            newDateArray[4] = dateArray[1];
            var newDate = new string(newDateArray);
            respond.InterviewDate = Convert.ToDateTime(newDate);

            respond.VacancyStage = Models.VacancyStage.InterviewAssigned;
            await _context.SaveChangesAsync();

            return RedirectToAction("ShowVacancyResponds", "Vacancies", new { vacId = model.vacId});
        }

        [HttpGet]
        [Route("VacancyResponds/SetStatusNoOffer/{respondId}")]
        public async Task<IActionResult> SetStatusNoOffer(int respondId, int vacId)
        {
            var model = new AssignInverviewViewModel { respondId = respondId };
            model.vacId = vacId;
            return View(model);
        }

        [HttpPost]        
        [Authorize]
        public async Task<IActionResult> SetStatusNoOffer(AssignInverviewViewModel model)
        {
            var respond = await _context.Responds.FirstOrDefaultAsync(x => x.Id == model.respondId);

            if (respond == null)
                return NotFound("No such respond");

            respond.VacancyStage = Models.VacancyStage.NoOffer;
            await _context.SaveChangesAsync();

            return RedirectToAction("ShowVacancyResponds", "Vacancies", new { vacId = model.vacId });
        }

        [HttpGet]
        [Route("VacancyResponds/SetStatusOfferSent/{respondId}")]
        public async Task<IActionResult> SetStatusOfferSent(int respondId, int vacId)
        {
            var model = new AssignInverviewViewModel { respondId = respondId };
            model.vacId = vacId;
            return View(model);
        }

        [HttpPost]      
        [Authorize]
        public async Task<IActionResult> SetStatusOfferSent(AssignInverviewViewModel model)
        {
            var respond = await _context.Responds.FirstOrDefaultAsync(x => x.Id == model.respondId);

            if (respond == null)
                return NotFound("No such respond");

            respond.VacancyStage = Models.VacancyStage.OfferSent;
            await _context.SaveChangesAsync();

            return RedirectToAction("ShowVacancyResponds", "Vacancies", new { vacId = model.vacId });
        }

        public async Task<IActionResult> ShowSelfResponds ()
        {
            var currentStudentId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await ShowStudentsResponds(currentStudentId);            
        }

        public async Task<IActionResult> ShowStudentsResponds (string studentId)
        {
            var currentStudent = await _context.Users.FirstOrDefaultAsync(x => x.Id == studentId);
            var responds = _context.Responds.Where(x => x.student == currentStudent).Include(y => y.vacancy);

            List<VacancyRespondViewModel> respondsDTO = new List<VacancyRespondViewModel>();

            foreach (var r in responds)
            {
                var currentVacancy = r.vacancy;

                respondsDTO.Add(new VacancyRespondViewModel
                {
                    Company = currentVacancy.Company,
                    VacancyStack = currentVacancy.Stack,
                    Slots = currentVacancy.Slots,
                    Position = currentVacancy.Position,                    

                    RespondId = r.Id,
                    VacancyId = currentVacancy.Id,

                    RespondStage = r.VacancyStage,
                    StudentsVerdict = r.StudentsVerdict,

                    InterviewDate = r.InterviewDate
                });
            }

            this.ViewData["Responds"] = respondsDTO;            

            return View();
        }

        [HttpGet]
        [Route("VacancyResponds/AcceptOffer/{respondId}")]
        public async Task<IActionResult> AcceptOffer (int respondId, int vacId)
        {
            var model = new AssignInverviewViewModel { respondId = respondId };
            model.vacId = vacId;
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AcceptOffer (AssignInverviewViewModel model)
        {
            var respond = await _context.Responds.FirstOrDefaultAsync(x => x.Id == model.respondId);

            if (respond == null)
                return NotFound("No such respond");
            
            respond.StudentsVerdict = Models.StudentsVerdict.Accepted;
            await _context.SaveChangesAsync();

            return RedirectToAction("ShowSelfResponds", new { });
        }

        [HttpGet]
        [Route("VacancyResponds/DeclineOffer/{respondId}")]
        public async Task<IActionResult> DeclineOffer (int respondId, int vacId)
        {
            var model = new AssignInverviewViewModel { respondId = respondId };
            model.vacId = vacId;
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeclineOffer (AssignInverviewViewModel model)
        {
            var respond = await _context.Responds.FirstOrDefaultAsync(x => x.Id == model.respondId);

            if (respond == null)
                return NotFound("No such respond");

            respond.StudentsVerdict = Models.StudentsVerdict.Declined;
            await _context.SaveChangesAsync();

            return RedirectToAction("ShowSelfResponds", new { });
        }
    }
}
