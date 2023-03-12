﻿using System.ComponentModel.DataAnnotations;

namespace ContactEFAPI.Models
{
    public partial class Contact
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public string? Phone { get; set; }
        public string? PhoneDescription { get; set; }
        public string? Email { get; set; }
        public string? EmailDescription { get; set; }
        public string? Notes { get; set; }

    }
}