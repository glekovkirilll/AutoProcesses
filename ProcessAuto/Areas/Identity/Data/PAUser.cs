using Microsoft.AspNetCore.Identity;
using ProcessAuto.Models;
using System;
using System.Collections.Generic;

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

        public ICollection<Resume> Resumes { get; set; }

        public Int32? Company { get; set; }

    }
}
