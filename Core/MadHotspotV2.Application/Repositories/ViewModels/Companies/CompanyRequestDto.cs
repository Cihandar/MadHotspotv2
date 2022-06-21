using AutoMapper;
using MadHotspotV2.Application.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Repositories.ViewModels.Companies
{
    public class CompanyRequestDto : ICustomMapping
    {
        public Guid Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AuthorizedPerson { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime LicanceStartDate { get; set; }
        public DateTime LicanceEndDate { get; set; }

        public void CreateMappings(Profile configuration)
        {
            
        }
    }
}
