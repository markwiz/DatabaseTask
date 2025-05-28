using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class JobTitle
{
    public int JobTitleId { get; set; }

    public string JobTitleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
