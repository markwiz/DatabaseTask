using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class AnonymousFeedback
{
    public int FeedbackId { get; set; }

    public string Text { get; set; } = null!;

    public DateTime SubmittedDate { get; set; }
}
