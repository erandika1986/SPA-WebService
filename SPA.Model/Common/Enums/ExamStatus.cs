using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SPA.Model
{
    public enum ExamStatus
    {
        [Description("Created")]
        Created = 1,
        [Description("Approval Requested")]
        ApprovalRequested = 2,
        [Description("Approved")]
        Approved = 3,
        [Description("Rejected")]
        Rejected = 4,
        [Description("Published")]
        Published = 5,
        [Description("Un-Published")]
        UnPublished = 6
    }
}
