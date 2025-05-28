﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class SickLeave
    {
        [Key]
        public int Sick_leave_ID { get; set; }

        public int Employee_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string? Reason { get; set; }
        public string? Description { get; set; }

        public Employee Employee { get; set; }
    }
}
