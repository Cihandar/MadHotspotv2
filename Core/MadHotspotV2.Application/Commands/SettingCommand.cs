using MadHotspotV2.Application.Dtos.Settings;
using MadHotspotV2.Application.Interfaces.Commands;
using MadHotspotV2.Application.Repositories;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Commands
{
    public class SettingCommand : ISettingCommand
    {
        private IWriteRepository<Setting> _writeRepository;
        private IReadRepository<Setting> _readRepository;
        public SettingCommand(IReadRepository<Setting> readRepository,IWriteRepository<Setting> writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public Task<bool> AddAsync(SettingsRequestDto datas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeAsync(List<SettingsRequestDto> datas)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Setting datas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRange(List<SettingsRequestDto> datas)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(SettingsRequestDto datas)
        {
            var setting = await _readRepository.GetByIdAsync(datas.CompanyId);

            setting.DailyPriceEUR = datas.DailyPriceEUR;
            setting.DailyPriceTL = datas.DailyPriceTL;
            setting.DailyPriceUSD = datas.DailyPriceUSD;
            setting.MikrotikIp = datas.MikrotikIp;
            setting.MikrotikPort = datas.MikrotikPort;
            setting.MikrotikUser = datas.MikrotikUser;
            if (!string.IsNullOrEmpty(datas.MikrotikPass)) setting.MikrotikPass = datas.MikrotikPass;
            setting.MikrotikDefaultPassword = datas.MikrotikDefaultPassword;
            setting.UnlimitedActive = datas.UnlimitedActive;
            setting.FullNameRequired = datas.FullNameRequired;
            setting.MikrotikHotspotName = datas.MikrotikHotspotName;
            setting.MikrotikProfilName = datas.MikrotikProfilName;
            setting.RefundActive = datas.RefundActive;
            setting.PriceListActive = datas.PriceListActive;
            setting.DiaIntegrationActive = datas.DiaIntegrationActive;
            setting.DiaUrl = datas.DiaUrl;
            //TODO : DUGHAN
            var response = _writeRepository.Update(setting);
            return response;
        }

        public bool UpdateRange(List<SettingsRequestDto> datas)
        {
            throw new NotImplementedException();
        }
    }
}
