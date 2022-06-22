using FluentValidation;
using MadHotspotV2.Application.Dtos.AppUsers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Validators.Auths
{
    public class RegisterAuthValidator : AbstractValidator<AppUserRegisterDto>
    {
        public RegisterAuthValidator()
        {
            RuleFor(x => x.companyRequestDto.CompanyName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Firma adı boş olamaz.")
                .MinimumLength(5).WithMessage("Firma adı karakter uzunluğu 5'ten küçük olamaz.")
                .MaximumLength(200).WithMessage("Firma adı karakter uzunluğu 200'den büyük olamaz");
            RuleFor(x => x.companyRequestDto.Email)
                .EmailAddress().WithMessage("Mail adresini lütfen doğru giriniz")
                .NotNull()
                .NotEmpty().WithMessage("Mail adresi boş bırakılamaz");
            RuleFor(x => x.companyRequestDto.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .WithMessage("Telefon boş bırakılamaz");
            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage("Lütfen bir şifre giriniz");          
        }
    }
}
