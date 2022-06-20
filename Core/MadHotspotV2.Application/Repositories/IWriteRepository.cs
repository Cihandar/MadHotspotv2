using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T datas);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T datas);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);
        bool Update(T datas);
        bool UpdateRange(List<T> datas);
        Task<int> SaveAsync();
    }
}
