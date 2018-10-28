﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model.Transaction
{
    public class StudentExamResult
    {
        public string StudentId { get; set; }
        public long ExamId { get; set; }
        public string AnswerSheet { get; set; }

        public virtual User Student { get; set; }
        public virtual Exam Exam { get; set; }

        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
