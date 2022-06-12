using ProcessAuto.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProcessAuto.Models
{
    public class VacancyUser
    {
        [Key]
        public int Id { get; set; }

        public PAUser student { get; set; }
        public Vacancy vacancy { get; set; }

        public DateTime InterviewDate { get; set; }
        public VacancyStage VacancyStage { get; set; }
        public StudentsVerdict StudentsVerdict { get; set; }
    }

    public enum VacancyStage
    {
        Sent,
        InterviewAssigned,
        OfferSent,
        NoOffer
    }

    public enum StudentsVerdict
    {
        Awaiting,
        Accepted,
        Declined
    }
}