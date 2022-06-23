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
    public class AuthCommand : IAuthCommand
    {
        LoginResponseDto _loginResponse;
        ICompanyQuery _companyQuery;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AuthCommand(LoginResponseDto loginResponse, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICompanyQuery companyQuery)
        {
            this._loginResponse = loginResponse;
            _userManager = userManager;
            _signInManager = signInManager;
            _companyQuery = companyQuery;
        }

        public AuthCommand()
        {
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                _loginResponse.Status = false;
                _loginResponse.Message = "Kullanıcı adı veya şifre yanlış.";
            }
            else
            {
                if (!await CheckLicence(user.CompanyId))
                {
                    _loginResponse.Status = false;
                    _loginResponse.Message = "Lisans süreniz dolmuştur.Lütfen yetkiliniz ile iletişime geçin.";
                }

            }
            var signResult  = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if(!signResult.Succeeded)
            {
                _loginResponse.Status = false;
                _loginResponse.Message = "Kullanıcı adı veya şifre yanlış.";
            }else
            {
                _loginResponse.Status = true;
                _loginResponse.Message = "Kullanıcı Girişi Başarılı..";
                _loginResponse.CompanyId = user.CompanyId;
                _loginResponse.Email = user.Email;
            }
            return _loginResponse;
        }

        private async Task<bool> CheckLicence(Guid companyId)
        {
            var companyResponseDto = await _companyQuery.GetByIdAsync(companyId);
            if (companyResponseDto.LicanceEndDate > DateTime.Now)
            {
                return false;
            }
            if (!companyResponseDto.Active) return false;
            return true;
        }

        public void RegisterAsync(AppUserRequestDto model)
        {
            throw new NotImplementedException();
        }
    }
}
