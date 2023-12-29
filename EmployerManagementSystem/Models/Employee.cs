using System.ComponentModel.DataAnnotations;

namespace EmployerManagementSystem.Models
{
    public class Employee
    {
        [Key]
        
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        public string EmailAddress { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set;}
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
