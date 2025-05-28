using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Models
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        public int? Department_ID { get; set; }
        public int? Job_Title_ID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string SocialSecurityNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(25)]
        public string PhoneNumber { get; set; }

        public string? Description { get; set; }

        public Department? Department { get; set; }
        public JobTitle? JobTitle { get; set; }
        public ICollection<Child>? Children { get; set; }
        public ICollection<Loan>? Loans { get; set; }
        public ICollection<HealthCheck>? HealthChecks { get; set; }
        public ICollection<Vacation>? Vacations { get; set; }
        public ICollection<SickLeave>? SickLeaves { get; set; }
        public ICollection<EmployeeAccess>? EmployeeAccesses { get; set; }
    }

}