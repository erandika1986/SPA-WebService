using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class StudentAttendance
    {
        public int AcademicYearId { get; set; }
        public string AcademicLevelId { get; set; }
        public long ClassNameId { get; set; }
        public string TodayDate { get; set; }
        public string StudentId { get; set; }
        public bool IsAttended { get; set; }
        public bool IsLateArrived { get; set; }
        public Nullable<DateTime> LateArriveTime { get; set; }
        public Nullable<long> LateComingOffenceId { get; set; }
        public string Remarks { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }

        public virtual StudentAttendaceBase StudentAttendaceBase { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual AcademicLevel AcademicLevel { get; set; }
        public virtual Class Class { get; set; }
        public virtual User Student { get; set; }
        public virtual StudentOffence StudentOffenceAndDeed { get; set; }
    }
}
