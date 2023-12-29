﻿using System.ComponentModel.DataAnnotations;

namespace EmployerManagementSystem.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set;} = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public double ZipCode { get; set; }
    }
}
