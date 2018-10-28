using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    class Semester
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int StudentCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long CreatedById { get; set; }
        public long UpdatedById { get; set; }
        public bool IsActive { get; set; }

        public virtual User Createdby { get; set; }
        public virtual User Updatedby { get; set; }
    }
}
