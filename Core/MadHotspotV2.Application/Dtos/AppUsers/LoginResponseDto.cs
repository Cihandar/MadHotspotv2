using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Dtos.AppUsers
{
    public class LoginResponseDto
    {
        public string Email { get; set; }
        public Guid CompanyId { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
