using FluentValidation;
using MadHotspotV2.Application.Repositories.ViewModels.Companies;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Repositories.Validators.Companies
{
    public class CreateCompanyValidator : AbstractValidator<CompanyRequestDto>
    {
        public CreateCompanyValidator()
        {
            RuleFor(x => x.CompanyName)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen Firma ismini belirleyin")
                .MaximumLength(200)
                .MinimumLength(3)
                    .WithMessage("Firma ismi 3 ila 200 karakter arası olabilir. ");
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Lütfen bir Email adresi belirleyin.")
                .EmailAddress()
                    .WithMessage("Lütfen doğru bir Email adresi girin.");
        }
    }
}
