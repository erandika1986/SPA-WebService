﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{

    public class StudentClass
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public long ClassNameId { get; set; }
        public int AcademicLevelId { get; set; }
        public int AcademicYearId { get; set; }
        public int RegNo { get; set; }

        public virtual User Student { get; set; }
        public virtual Class Class { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedById { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long? UpdatedById { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
