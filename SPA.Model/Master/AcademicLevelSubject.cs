using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class AcademicLevelSubject
    {
        public int AcademicLevelId { get; set; }
        public int SubjectId { get; set; }
        public bool IsActive { get; set; }
    }
}
