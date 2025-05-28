using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Child
{
    public int ChildId { get; set; }

    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public int EmployeeId1 { get; set; }

    public virtual Employee EmployeeId1Navigation { get; set; } = null!;
}
