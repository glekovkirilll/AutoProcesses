﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcessAuto.Data;
using ProcessAuto.Models.ViewModels;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProcessAuto.Controllers
{
    public class ResumeController : Controller
    {

        private readonly ApplicationDbContext _context;

        //UserManager<IdentityUser> _userManager;

        public ResumeController(ApplicationDbContext context)
        {
            _context = context;
            //_userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //var student = await this._context.Users.SingleOrDefaultAsync(x => x.Id == studentId);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUserResume = await _context.Resumes.FirstOrDefaultAsync(x => x.student.Id == userId);
            this.ViewBag.Student = User.Identity.Name;
            if (currentUserResume != default)
            {
                ResumeViewModel model = new ResumeViewModel
                {
                    /*AboutYourself = "kek",
                    Stack = "kek",
                    Hobbies = "kek",
                    WorkingExperience = "kek",
                    ProgrammingLanguages = "kek"*/
                    AboutYourself = currentUserResume.AboutYourself,
                    Stack = currentUserResume.Stack,
                    Hobbies = currentUserResume.Hobbies,
                    WorkingExperience = currentUserResume.WorkingExperience,
                    ProgrammingLanguages = currentUserResume.ProgrammingLanguages

                    
                };
                return View(model);
            }
            else return StatusCode(404, "Not Found");            
        }

        public IActionResult Test()
        {
            return StatusCode(200, "It is working!");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUserResume = await _context.Resumes.FirstOrDefaultAsync(x => x.student.Id == userId);
            if (currentUserResume != default)
            {
                var model = new ResumeViewModel
                {
                    AboutYourself = currentUserResume.AboutYourself,
                    Stack = currentUserResume.Stack,
                    Hobbies = currentUserResume.Hobbies,
                    WorkingExperience = currentUserResume.WorkingExperience,
                    ProgrammingLanguages = currentUserResume.ProgrammingLanguages
                };
                return View(model);
            }
            else return StatusCode(404, "NotFound");
                /*var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var currentUserResume = await _context.Resumes.FirstOrDefaultAsync(x => x.student.Id == userId);
                if (currentUserResume != default)
                {
                    currentUserResume.WorkingExperience = "kek";
                    currentUserResume.ProgrammingLanguages = "kek";
                    currentUserResume.Hobbies = "kek";
                    currentUserResume.Stack = "kek";
                    currentUserResume.AboutYourself = "kek";
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                else return StatusCode(404, "Not found");*/
            }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(ResumeViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUserResume = await _context.Resumes.FirstOrDefaultAsync(x => x.student.Id == userId);
            if (currentUserResume != default)
            {
                currentUserResume.WorkingExperience = model.WorkingExperience;
                currentUserResume.ProgrammingLanguages = model.ProgrammingLanguages;
                currentUserResume.Hobbies = model.Hobbies;
                currentUserResume.Stack = model.Stack;
                currentUserResume.AboutYourself = model.AboutYourself;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");                
            }
            else return StatusCode(404, "Not found");
        }
    }
}