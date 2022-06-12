using System;

namespace ProcessAuto.Models.ViewModels
{
    public class VacancyRespondViewModel
    {
        public int RespondId { get; set; }
        public int VacancyId { get; set; }
        public int StudentId { get; set; }


        //Personal Info
        public string Email { get; set; }

        //Resume data
        public string AboutYourself { get; set; }
        public string Hobbies { get; set; }
        public string Stack { get; set; }
        public string WorkingExperience { get; set; }
        public string ProgrammingLanguages { get; set; }

        //vacancy data
        public string Company { get; set; }       
        public string Position { get; set; }
        public string VacancyStack { get; set; }        
        public string Slots { get; set; }

        public VacancyStage RespondStage { get; set; }
        public StudentsVerdict StudentsVerdict { get; set; }
        public DateTime InterviewDate { get; set; }
       
    }
}
