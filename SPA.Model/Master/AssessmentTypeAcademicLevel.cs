﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class AssessmentTypeAcademicLevel
    {
        public int AssessmentTypeId { get; set; }
        public int AcademicLevelId { get; set; }

        public virtual AssessmentType AssessmentType { get; set; }
        public virtual AcademicLevel AcademicLevel { get; set; }

        public DateTime CreatedOn { get; set; }
        public long? CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long? UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }
    }
}
