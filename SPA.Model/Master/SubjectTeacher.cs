using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class SubjectTeacher
    {
        public long ClassNameId { get; set; }
        public string AcademicLevelId { get; set; }
        public int AcademicYearId { get; set; }
        public string SubjectId { get; set; }
        public long TeacherId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual User Teacher { get; set; }

        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
