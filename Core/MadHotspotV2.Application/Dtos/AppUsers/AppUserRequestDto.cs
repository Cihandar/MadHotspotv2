using MadHotspotV2.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Dtos.AppUsers
{
    public class AppUserRequestDto
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string AvatarUrl { get; set; }
        public byte Status { get; set; }
        public Guid CompanyId { get; set; }
        public PermissionEnum UserType { get; set; }
        public bool Admin { get; set; }
    }
}
