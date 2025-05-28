using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Equipment
    {
        [Key]
        public int Equipment_ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string Condition { get; set; } // Enum as string: NEW, GOOD, NEEDS_REPAIRING

        public string? Description { get; set; }

        public ICollection<Loan>? Loans { get; set; }
    }

}
