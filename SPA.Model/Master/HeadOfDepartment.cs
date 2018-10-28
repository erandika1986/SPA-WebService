using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class HeadOfDepartment
    {
        public long Id { get; set; }
        public int AcademicYearId { get; set; }
        public int AcademicLevelId { get; set; }
        public int SubjectId { get; set; }
        public long TeacherId { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual AcademicLevel AcademicLevel { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual User Teacher { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
