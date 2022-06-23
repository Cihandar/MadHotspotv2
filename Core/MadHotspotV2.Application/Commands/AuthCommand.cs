using MadHotspotV2.Application.Dtos.AppUsers;
using MadHotspotV2.Application.Interfaces;
using MadHotspotV2.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MadHotspotV2.Application.Commands
{
    class AuthCommand : IAuthCommand
    {
        LoginResponseDto _loginResponse;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AuthCommand(LoginResponseDto loginResponse, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this._loginResponse = loginResponse;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public AuthCommand()
        {
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user==null)
            {
                _loginResponse.Status = false;
                _loginResponse.Message = "Kullanıcı adı veya şifre yanlış.";
            }
            else
            {

            }
        }

        public void RegisterAsync(AppUserRequestDto model)
        {
            throw new NotImplementedException();
        }
    }
}
