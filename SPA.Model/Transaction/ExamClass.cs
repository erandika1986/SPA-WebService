using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model.Transaction
{
    public class ExamClass
    {
        public long ClassNameId { get; set; }
        public string AcademicLevelId { get; set; }
        public int AcademicYearId { get; set; }
        public long ExamId { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Class Class { get; set; }

        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
