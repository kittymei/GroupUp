using System;
using System.Collections.Generic;

namespace GroupUp.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string HireDate { get; set; }
        public int? Phone { get; set; }
    }
}
