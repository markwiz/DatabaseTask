using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
   public class HealthCheck
    {
        [Key]
        public int Health_Check_ID { get; set; }

        public int Employee_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
