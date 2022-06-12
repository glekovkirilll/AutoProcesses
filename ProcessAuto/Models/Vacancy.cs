using System;
using System.ComponentModel.DataAnnotations;

namespace ProcessAuto.Models
{
    public class Vacancy
    {

        [Key]
        public int Id { get; set; }        

        public string Company { get; set; }
        public int CompanyId { get; set; }
        public string Position { get; set; }        
        public string Stack { get; set; }
        public string Slots { get; set; }                      
    }
   
}
