using MadHotspotV2.Application.Interfaces.Queries;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Queries
{
    public class SettingQuery : ISettingsQuery
    {
        public IQueryable<Setting> GetAll(bool Tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Setting> GetByIdAsync(string id, bool Tracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Setting> GetSingleAsync(Expression<Func<Setting, bool>> method, bool Tracking = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Setting> GetWhere(Expression<Func<Setting, bool>> method, bool Tracking = true)
        {
            throw new NotImplementedException();
        }
    }
}
