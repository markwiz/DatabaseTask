using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class JobTitle
    {
        [Key]
        public int Job_Title_ID { get; set; }

        [MaxLength(100)]
        public string Job_title_name { get; set; }

        public string? Description { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
