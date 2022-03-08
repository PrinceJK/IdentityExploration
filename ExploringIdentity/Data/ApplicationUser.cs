using Microsoft.AspNetCore.Identity;
using System;

namespace ExploringIdentity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public DateTime CareerStarted { get; set; }
    }
}
