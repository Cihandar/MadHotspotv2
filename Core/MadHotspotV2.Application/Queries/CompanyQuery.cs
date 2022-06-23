using AutoMapper;
using MadHotspotV2.Application.Dtos.Companies;
using MadHotspotV2.Application.Interfaces;
using MadHotspotV2.Application.Repositories;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Queries
{
    public class CompanyQuery : ICompanyQuery
    {
        IReadRepository<Company> _readRepository;
        IMapper _IMapper;

        public CompanyQuery(IReadRepository<Company> readRepository, IMapper ıMapper)
        {
            _readRepository = readRepository;
            _IMapper = ıMapper;
        }

        public async Task<CompanyResponseDto> GetByIdAsync(Guid CompanyId, bool trakcing = true)
        {
            Company company = await _readRepository.GetByIdAsync(CompanyId, trakcing);
            return _IMapper.Map<CompanyResponseDto>(company);
        }
    }
}
