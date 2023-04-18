using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.EMail).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı En Az 5 Karaterden Oluşmalıdır.");
            RuleFor(x => x.Password).Equal(h=>h.ConfirmPassword).WithMessage("Şifreler Eşleşmiyor.");

        }
    }
    
}
