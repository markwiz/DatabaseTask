using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class EmployeeAccess
{
    public int EmployeeAccessId { get; set; }

    public int EmployeeId { get; set; }

    public string? Description { get; set; }

    public int EmployeeId1 { get; set; }

    public virtual Employee EmployeeId1Navigation { get; set; } = null!;
}
