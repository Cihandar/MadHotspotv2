using MadHotspotV2.Domain.Entities.Common;
using MadHotspotV2.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
    public class CompanyUser : BaseModel
    {
        public string UserCode { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public PermissionEnum UserType { get; set; }
    }
}
