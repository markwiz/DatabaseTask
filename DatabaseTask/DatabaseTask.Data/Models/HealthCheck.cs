using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class HealthCheck
{
    public int HealthCheckId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Description { get; set; }

    public int EmployeeId1 { get; set; }

    public virtual Employee EmployeeId1Navigation { get; set; } = null!;
}
