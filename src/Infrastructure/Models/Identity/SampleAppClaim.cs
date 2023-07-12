using System;
using SampleApp.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace SampleApp.Infrastructure.Models.Identity
{
    public class SampleAppRoleClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual SampleAppRole Role { get; set; }

        public SampleAppRoleClaim() : base()
        {
        }

        public SampleAppRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}