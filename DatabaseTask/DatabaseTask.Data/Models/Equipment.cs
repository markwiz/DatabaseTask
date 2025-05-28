using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Equipment
{
    public int EquipmentId { get; set; }

    public string Name { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
