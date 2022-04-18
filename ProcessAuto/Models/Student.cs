using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProcessAuto.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Resume> Resumes { get; set; }
    }
}
