using MadHotspotV2.Application.Dtos.AppUsers;
using MadHotspotV2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Commands
{
    class AuthCommand : IAuthCommand
    {
        
        public AuthCommand()
        {
        }

        public void LoginAsync(AppUserRequestDto model)
        {
            
        }

        public void RegisterAsync(AppUserRequestDto model)
        {
            throw new NotImplementedException();
        }
    }
}
