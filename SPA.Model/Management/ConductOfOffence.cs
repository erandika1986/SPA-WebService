using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class ConductOfOffence
    {
        public long Id { get; set; }
        public int AcademicYearId { get; set; }
        public string AcademicLevelId { get; set; }
        public long ClassNameId { get; set; }
        //public string StudentId { get; set; }
        public long OffenceAndDeedId { get; set; }
        public bool IsCyberOffence { get; set; }
        public bool IsWithPoliceCase { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

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
        public virtual User Student { get; set; }
        public virtual Offence OffenceAndDeed { get; set; }

        public virtual ICollection<StudentOffence> StudentOffenceAndDeeds { get; set; }

    }
}
