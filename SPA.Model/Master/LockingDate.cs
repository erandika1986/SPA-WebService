using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class LockingDate
    {
        public int AcademicYearId { get; set; }
        public int AcademicLevelId { get; set; }
        public int SubjectId { get; set; }
        public int AssessmentTypeId { get; set; }
        public DateTime? TOSLockingDate { get; set; }
        public DateTime? ResultLockingDate { get; set; }
        public bool HasExam { get; set; }
        public bool IsResultMigrated { get; set; }
        public DateTime? MigratedDate { get; set; }

        public AcademicYear AcademicYear { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        public Subject Subject { get; set; }
        public AssessmentType AssessmentType { get; set; }

        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }
    }
}
