using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class StudentOffence
    {
        public string SudentId { get; set; }
        public long OffenceId { get; set; }
        public bool IsActive { get; set; }

        public virtual User Student { get; set; }
        public virtual ConductOfOffence ConductOfOffenceAndDeed { get; set; }

        public virtual ICollection<StudentAttendance> StudentAttendances { get; set; }
    }
}
