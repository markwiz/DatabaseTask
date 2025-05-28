using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Child
    {
        [Key]
        public int Child_ID { get; set; }

        public int Employee_ID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public Employee Employee { get; set; }
    }

}
