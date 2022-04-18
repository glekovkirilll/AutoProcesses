using ProcessAuto.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ProcessAuto.Models
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }
        //public int StudentId { get; set; }
        public PAUser student { get; set; }

        public string AboutYourself { get; set; }
        public string Hobbies { get; set; }
        public string Stack { get; set; }
        public string WorkingExperience { get; set; }
        public string ProgrammingLanguages { get; set; }
    }
}
