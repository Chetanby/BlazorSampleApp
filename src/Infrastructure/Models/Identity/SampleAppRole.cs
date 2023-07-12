using System;
using System.Collections.Generic;
using SampleApp.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace SampleApp.Infrastructure.Models.Identity
{
    public class SampleAppRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<SampleAppRoleClaim> RoleClaims { get; set; }

        public SampleAppRole() : base()
        {
            RoleClaims = new HashSet<SampleAppRoleClaim>();
        }

        public SampleAppRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<SampleAppRoleClaim>();
            Description = roleDescription;
        }
    }
}