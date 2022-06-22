using MadHotspotV2.Application.Dtos.Companies;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Dtos.AppUsers
{
    public class AppUserRegisterDto
    {
        public CompanyRequestDto companyRequestDto { get; set; }
        public string Password { get; set; }
    }
}
