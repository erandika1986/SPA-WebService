using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class ExamApproval
    {
        public long Id { get; set; }
        public long ExamId { get; set; }
        public ApprovalAction Action { get; set; }
        public string Comment { get; set; }
        public DateTime ActionDate { get; set; }
        public long ActionById { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual User ActionBy { get; set; }
    }
}
