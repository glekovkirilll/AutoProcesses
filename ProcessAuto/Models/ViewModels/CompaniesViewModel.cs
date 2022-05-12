using System;

namespace ProcessAuto.Models.ViewModels
{
    public class CompaniesViewModel
    {        
        public Int32 Id { get; set; }
        public String Name { get; set; }        
        public String? Info { get; set; }
        public String? LinkToWebsite { get; set; }

    }
}
