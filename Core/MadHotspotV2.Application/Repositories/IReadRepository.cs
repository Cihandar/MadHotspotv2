using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> GetAll(bool Tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool Tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool Tracking = true);
        Task<T> GetByIdAsync(Guid id, bool Tracking = true);        
    }
}
