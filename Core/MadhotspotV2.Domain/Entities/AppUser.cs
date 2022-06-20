using MadHotspotV2.Domain.Entities.Common;
using MadHotspotV2.Domain.Enumerations;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string AvatarUrl { get; set; }
        public byte Status { get; set; }
        public Guid CompanyId { get; set; }
        public PermissionEnum UserType { get; set; }
        public bool Admin { get; set; }
    }
}
