using MadHotspotV2.Application.Repositories;
using MadHotspotV2.Domain.Entities.Common;
using MadHotspotV2.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseModel
    {
        private readonly MadHotspotV2DbContext _context;

        public WriteRepository(MadHotspotV2DbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T datas)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(datas);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T datas)
        {
            EntityEntry entityEntry = Table.Remove(datas);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }

        public bool Update(T datas)
        {
            EntityEntry entityEntry = Table.Update(datas);
            return entityEntry.State == EntityState.Modified;
        }

        public bool UpdateRange(List<T> datas)
        {
            Table.UpdateRange(datas);
            return true;
        }

        public Task<int> SaveAsync()
            => _context.SaveChangesAsync();
    }
}
