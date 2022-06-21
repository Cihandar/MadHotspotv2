using MadHotspotV2.Application.Repositories.Companies;
using MadHotspotV2.Domain.Entities;
using MadHotspotV2.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Persistence.Repositories.Companies
{
    public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
    {
        public CompanyReadRepository(MadHotspotV2DbContext context) : base(context)
        {
        }
    }
}
