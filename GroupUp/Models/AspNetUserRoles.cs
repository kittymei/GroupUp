using System;
using System.Collections.Generic;

namespace GroupUp.Models
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
