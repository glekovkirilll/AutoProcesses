using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcessAuto.Areas.Identity.Data;
using ProcessAuto.Data;
using ProcessAuto.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAuto.Controllers
{
    public class DeaneryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeaneryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Deanery/ShowAllStudents")]
        public async Task<IActionResult> ShowAllStudents()
        {
            var students = _context.Users;
            List<StudentViewModel> studs = new List<StudentViewModel>();
            foreach (var student in students)
            {
                var userRole = _context.UserRoles.FirstOrDefault(x => x.UserId == student.Id);
                if (userRole == default)
                    continue;
                var roleId = userRole.RoleId;
                var role = _context.Roles.FirstOrDefault(x => x.Id == roleId);
                var roleName = role.Name;
                if (roleName == "Student")
                {
                    studs.Add(new StudentViewModel
                    {
                        Id = student.Id,
                        Name = student.Name,
                        Surname = student.Surname,
                        Middlename = student.MiddleName
                    });
                }
            }
            this.ViewData["Students"] = studs;            
            return View();
        }

        [HttpGet]
        [Route("Deanery/ShowStudentsProgress/{studentId}")]

        public async Task<IActionResult> ShowStudentsProgress(string studentId)
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

            this.ViewData["Fullname"] = "test";

            return View();
        }
    }
}
