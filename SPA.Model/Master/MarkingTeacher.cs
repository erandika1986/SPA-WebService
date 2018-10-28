using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class MarkingTeacher
    {
        public long Id { get; set; }
        public int AcademicYearId { get; set; }
        public int AcademicLevelId { get; set; }
        public int SubjectId { get; set; }
        public long TeacherId { get; set; }

        public AcademicYear AcademicYear { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        public Subject Subject { get; set; }
        public User Teacher { get; set; }

        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
