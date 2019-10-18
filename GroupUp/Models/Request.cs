using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroupUp.Models
{
    public partial class Request
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a subect")]
        public string Subject { get; set; }
        public string Topic { get; set; }
        public string SchoolType { get; set; }
        public string Experience { get; set; }
        public DateTime? StudyDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? ZipCode { get; set; }
    }
}
