using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Interfaces.Queries
{
    public interface ISettingsQuery
    {
        IQueryable<Setting> GetAll(bool Tracking = true);
        IQueryable<Setting> GetWhere(Expression<Func<Setting, bool>> method, bool Tracking = true);
        Task<Setting> GetSingleAsync(Expression<Func<Setting, bool>> method, bool Tracking = true);
        Task<Setting> GetByIdAsync(string id, bool Tracking = true);
    }
}
