using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Dtos.Settings
{
    public class SettingsResponseDto
    {
        public Guid Id { get; set; }
        public bool UnlimitedActive { get; set; } //Sınırsız Aktif
        public double DailyPriceTL { get; set; }
        public double DailyPriceUSD { get; set; }
        public double DailyPriceEUR { get; set; }
        public string MikrotikIp { get; set; }
        public string MikrotikPort { get; set; }
        public string MikrotikUser { get; set; }
        public string MikrotikPass { get; set; }
        public string MikrotikHotspotName { get; set; }
        public string MikrotikProfilName { get; set; }
        public string MikrotikDefaultPassword { get; set; }
        public bool FullNameRequired { get; set; }  //Ad Soyad Zorunlu
        public bool RefundActive { get; set; }
        public bool PriceListActive { get; set; }
        public bool DiaIntegrationActive { get; set; }  //Dia Entegrasyon Aktif 
        public string DiaUrl { get; set; }
    }
}
