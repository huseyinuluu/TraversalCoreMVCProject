using EntityKatman.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Yetkili Adını Giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Yetkili Açıklama Giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Yetkili Resim Yükleyiniz");
        }
    }
}
