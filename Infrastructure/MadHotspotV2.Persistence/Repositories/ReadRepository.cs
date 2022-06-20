using MadHotspotV2.Application.Repositories;
using MadHotspotV2.Domain.Entities.Common;
using MadHotspotV2.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseModel
    {
        private readonly MadHotspotV2DbContext _context;

        public ReadRepository(MadHotspotV2DbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);

        public IQueryable<T> GetCompanyData(string id)
            => Table.Where(data => data.CompanyId == Guid.Parse(id));

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public Task<T> GetByIdAsync(string id)
            => Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));


    }
}
