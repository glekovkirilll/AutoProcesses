using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProcessAuto.Areas.Identity.Data;

namespace ProcessAuto.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<PAUser> _userManager;
        private readonly SignInManager<PAUser> _signInManager;

        public IndexModel(
            UserManager<PAUser> userManager,
            SignInManager<PAUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [DataType(DataType.Text)]
            [Display(Name = "Имя пользователя")]
            public string Username { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Фамилия")]
            public string Surname { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Имя")]
            public string Name { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Отчество")]
            public string MiddleName { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата Рождения")]
            public DateTime DateOfBirth { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(PAUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            

            Input = new InputModel
            {
                Username = userName,
                Surname = user.Surname,
                Name = user.Name,
                MiddleName = user.MiddleName,
                DateOfBirth = user.DateOfBirth,
                PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            
            if(Input.Surname != user.Surname)
            {
                user.Surname = Input.Surname;
            }

            if (Input.Name != user.Name)
            {
                user.Name = Input.Name;
            }

            if (Input.MiddleName != user.MiddleName)
            {
                user.MiddleName = Input.MiddleName;
            }

            if (Input.DateOfBirth != user.DateOfBirth)
            {
                user.DateOfBirth = Input.DateOfBirth;
            }

            

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
