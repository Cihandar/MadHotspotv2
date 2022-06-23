using MadHotspotV2.Application.Repositories.Settings;
using MadHotspotV2.Domain.Entities;
using MadHotspotV2.Persistence.Contexts;

namespace MadHotspotV2.Persistence.Repositories.Settings
{
    public class SettingWriteRepository : WriteRepository<Setting>, ISettingsWriteRepository
    {
        public SettingWriteRepository(MadHotspotV2DbContext context) : base(context)
        {
        }
    }
}
