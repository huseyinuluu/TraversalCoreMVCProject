using EntityKatman.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            // Açıklamalar
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu Alan Boş Geçilemez...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(x => x.Description).NotEmpty().MinimumLength(20).WithMessage("En az 20 karakter giriniz");

        }
    }
}
