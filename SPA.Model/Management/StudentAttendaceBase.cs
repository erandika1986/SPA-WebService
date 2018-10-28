using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class StudentAttendaceBase
    {
        public int AcademicYearId { get; set; }
        public string AcademicLevelId { get; set; }
        public long ClassNameId { get; set; }
        public string TodayDate { get; set; }
        public bool IsHoliday { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }
        public virtual AcademicLevel AcademicLevel { get; set; }
        public virtual Class Class { get; set; }

        public virtual ICollection<StudentAttendance> StudentAttendances { get; set; }

    }
}
