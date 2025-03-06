﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrizaAuth.Database.Identity
{
    public class UserRole : IdentityUserRole<int>
    {
        public virtual User User { get; set; } = default!;

        public virtual Role Role { get; set; } = default!;
    }
}
