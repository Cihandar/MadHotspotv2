using MadHotspotV2.Application.Dtos.AppUsers;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Interfaces
{
    public interface IAuthCommand
    {
        void LoginAsync(AppUserRequestDto model);
        void RegisterAsync(AppUserRequestDto model);
    }
}
