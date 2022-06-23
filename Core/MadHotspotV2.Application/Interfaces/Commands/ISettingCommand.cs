using MadHotspotV2.Application.Dtos.Settings;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Interfaces.Commands
{
    public interface ISettingCommand
    {
        Task<bool> AddAsync(SettingsRequestDto datas);
        Task<bool> AddRangeAsync(List<SettingsRequestDto> datas);
        bool Remove(Setting datas);
        bool RemoveRange(List<SettingsRequestDto> datas);
        Task<bool> RemoveAsync(string id);
        Task<bool> Update(SettingsRequestDto datas);
        bool UpdateRange(List<SettingsRequestDto> datas);
        Task<int> SaveAsync();
    }
}
