using MadHotspotV2.Application.Dtos.AppUsers;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Interfaces
{
    public interface IAuthCommand
    {
        Task<LoginResponseDto> LoginAsync(LoginRequestDto model);
        void RegisterAsync(AppUserRequestDto model);
    }
}
