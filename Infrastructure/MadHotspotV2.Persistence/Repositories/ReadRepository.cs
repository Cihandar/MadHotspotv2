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

        public IQueryable<T> GetAll(bool Tracking)
        {
            var query = Table.AsQueryable();
            if (!Tracking) query = Table.AsNoTracking();
            return Table;
        }


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool Tracking)
        {
            var query = Table.Where(method);
            if (!Tracking) query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool Tracking)
        {
            var query = Table.AsQueryable();
            if (!Tracking) query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public async Task<T> GetByIdAsync(string id, bool Tracking)
        {
            var query = Table.AsQueryable();
            if (!Tracking) query.AsNoTracking();
            return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        }


    }
}
