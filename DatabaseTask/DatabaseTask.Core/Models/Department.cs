using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }

        [MaxLength(100)]
        public string Department_Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
