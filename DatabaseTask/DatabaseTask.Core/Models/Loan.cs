using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class Loan
    {
        [Key]
        public int Loan_ID { get; set; }

        public int Employee_ID { get; set; }
        public int Equipment_ID { get; set; }

        public DateTime LoanStartDate { get; set; }
        public DateTime LoanLastDate { get; set; }

        public string? Description { get; set; }

        public Employee Employee { get; set; }
        public Equipment Equipment { get; set; }
    }
}
