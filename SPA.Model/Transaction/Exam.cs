using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model.Transaction
{
    public class Exam
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ExamPaparName { get; set; }
        public string ExamPaper { get; set; }
        public int SubjectId { get; set; }
        public int AcademicLevelId { get; set; }
        public int AssessmentTypeId { get; set; }
        public int AcademicYearID { get; set; }
        public ExamStatus Status { get; set; }
        public int Version { get; set; }


        public virtual Subject Subject { get; set; }
        public virtual AcademicLevel AcademicLevel { get; set; }
        public virtual AssessmentType AssessmentType { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }

        public virtual ICollection<ExamClass> ExamClasses { get; set; }
        public virtual ICollection<ExamApproval> ExamApprovals { get; set; }
    }
}
