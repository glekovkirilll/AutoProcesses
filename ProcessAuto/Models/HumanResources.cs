using System;

namespace ProcessAuto.Models
{
    public class HumanResources
    {
        public Guid Id { get; set; } = new Guid();
        public String Surname { get; set; }
        public String Name { get; set; }
        public String MiddleName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Int32 Company { get; set; }
    }
}
