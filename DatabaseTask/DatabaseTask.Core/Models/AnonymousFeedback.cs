using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Models
{
    public class AnonymousFeedback
    {
        [Key]
        public int Feedback_ID { get; set; }

        public string Text { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}
