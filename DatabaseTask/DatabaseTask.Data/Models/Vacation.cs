using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Vacation
{
    public int VacationId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int ExtraChildDayVacation { get; set; }

    public string? Description { get; set; }

    public int EmployeeId1 { get; set; }

    public virtual Employee EmployeeId1Navigation { get; set; } = null!;
}
