using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class Topic
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int AcademicLevelId { get; set; }
        public int AssessentTypeId { get; set; }

        public Subject Subject { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        public AssessmentType AssessmentType { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
