using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model.Analysis
{
    public class StudentSubjectTarget
    {
        public long StudentId { get; set; }
        public int SubjectId { get; set; }
        public int AcademicLevelId { get; set; }
        public int AssessmentTypeId { get; set; }
        public int AcademicYearID { get; set; }
        public decimal TargetScore { get; set; }
        public decimal TargetAdditionScore { get; set; }
        public decimal ActualScore { get; set; }
        public decimal ActualAdditionalScore { get; set; }
    }
}
