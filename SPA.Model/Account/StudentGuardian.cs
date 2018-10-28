using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class StudentGuardian
    {
        public long StudentId { get; set; }
        public long GuardianId { get; set; }
        public GuardianType Type { get; set; }

        public virtual User Student { get; set; }
        public virtual User Guardian { get; set; }

    }
}
