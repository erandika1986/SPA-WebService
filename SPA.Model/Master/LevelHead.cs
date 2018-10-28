using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class LevelHead
    {
        public long Id { get; set; }
        public long TeacherId { get; set; }
        public int AcademicLevelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
