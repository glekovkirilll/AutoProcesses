using System;
using System.ComponentModel.DataAnnotations;

namespace ProcessAuto.Models.ViewModels
{
    public class AssignInverviewViewModel
    {
        public int respondId { get; set; }
        public int vacId { get; set; }

        public string InterviewDate { get; set; }

    }
}
