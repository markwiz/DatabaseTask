using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? JobTitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string SocialSecurityNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Description { get; set; }

    public int? DepartmentId1 { get; set; }

    public int? JobTitleJobTitleId { get; set; }

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();

    public virtual Department? DepartmentId1Navigation { get; set; }

    public virtual ICollection<EmployeeAccess> EmployeeAccesses { get; set; } = new List<EmployeeAccess>();

    public virtual ICollection<HealthCheck> HealthChecks { get; set; } = new List<HealthCheck>();

    public virtual JobTitle? JobTitleJobTitle { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public virtual ICollection<SickLeaf> SickLeaves { get; set; } = new List<SickLeaf>();

    public virtual ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
}
