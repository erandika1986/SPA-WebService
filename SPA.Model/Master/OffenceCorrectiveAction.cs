using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class OffenceCorrectiveAction
    {
        public int Id { get; set; }
        public long OffenceId { get; set; }
        public string Action { get; set; }
    }
}
