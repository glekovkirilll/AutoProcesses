using Microsoft.AspNetCore.Identity;
using System;

namespace ProcessAuto.Areas.Identity.Data
{
    public class PAUser: IdentityUser
    {
        [PersonalData]
        public string Surname { get; set; }
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public string MiddleName { get; set; }
        [PersonalData]
        public DateTime DateOfBirth { get; set; }

    }
}
