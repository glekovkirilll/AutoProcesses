using ProcessAuto.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace ProcessAuto.Models
{
    public class VacancyUser
    {
        [Key]
        public int Id { get; set; }

        public PAUser student { get; set; }
        public Vacancy vacancy { get; set; }

    }
}
