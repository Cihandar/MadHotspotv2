using MadHotspotV2.Application.Dtos.Companies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Interfaces
{
    public interface ICompanyQuery
    {
        Task<CompanyResponseDto> GetByIdAsync(Guid CompanyId, bool tracking = true);
    }
}
