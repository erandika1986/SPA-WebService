using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SPA.Model
{
    public enum ApprovalAction
    {
        [Description("New")]
        Created = 1,
        [Description("Approval Requested")]
        Requested = 2,
        [Description("Approved")]
        Approved = 3,
        [Description("Rejected")]
        Rejected = 4,
        [Description("Published")]
        Published = 5,
        [Description("UnPublished")]
        UnPublished = 6
    }
}
