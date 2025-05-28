using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Loan
{
    public int LoanId { get; set; }

    public int EmployeeId { get; set; }

    public int EquipmentId { get; set; }

    public DateTime LoanStartDate { get; set; }

    public DateTime LoanLastDate { get; set; }

    public string? Description { get; set; }

    public int EmployeeId1 { get; set; }

    public int EquipmentId1 { get; set; }

    public virtual Employee EmployeeId1Navigation { get; set; } = null!;

    public virtual Equipment EquipmentId1Navigation { get; set; } = null!;
}
