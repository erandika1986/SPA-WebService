using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPA.Model
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNo { get; set; }
        public string NICNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<User> Students { get; set; }
        public virtual ICollection<User> Guardian { get; set; }
    }
}
