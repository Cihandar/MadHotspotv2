using MadHotspotV2.Application.Dtos.Base;
using MadHotspotV2.Application.Dtos.Settings;
using MadHotspotV2.Application.Interfaces.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadHotspotV2.WebUI.Controllers
{
    public class AyarlarController : BaseController
    {
        private ISettingCommand _settingCommand;
        public AyarlarController(ISettingCommand settingCommand)
        {
            _settingCommand = settingCommand;
        }

        public IActionResult Index()
        {
            //var data = context.H_Ayarlar.FirstOrDefault(x => x.FirmaId == FirmaId);
            //data.MikrotikPass = null;
            return View();
        }

        public IActionResult FirmaAl()
        {
            //var firma = context.H_Firmalar.FirstOrDefault(x => x.Id == FirmaId);
            return Json(null);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SettingsRequestDto ayarlar)
        {
            var retVal = new Response();

            try
            {
                var result = await _settingCommand.Update(ayarlar);
                return Ok(new Response { Success = result, Message = "Kayıt Başarılı" });

            }
            catch (Exception)
            {
                return Ok(new Response { Success = false, Message = "Hata Döndü. Bir Dön bak kendine... " }); ;
            }
        }

        public IActionResult TestMikrotik(SettingsRequestDto ayar)
        {
            try
            {
                var retVal = new Response();
                //int port = 0;
                //int.TryParse(ayar.MikrotikPort, out port);

                //using (var conn = ConnectionFactory.OpenConnection(TikConnectionType.Api_v2, ayar.MikrotikIp, port, ayar.MikrotikUser, ayar.MikrotikPass))
                //{
                //    if (!conn.IsOpened) conn.Open(ayar.MikrotikIp, port, ayar.MikrotikUser, ayar.MikrotikPass);
                //    conn.Close();
                //    return Ok(new Response { Success = true, Message = "Erişim Sağlandı" });
                //}
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(new Response { Success = false, Message = ex.Message }); ;
            }
        }
    }
}
