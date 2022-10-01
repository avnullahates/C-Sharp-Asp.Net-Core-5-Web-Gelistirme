using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adi Bos gecilemez");
            RuleFor(x=>x.ImageURL).NotEmpty().WithMessage("Gorsel Alani bos gecilemez");
            RuleFor(x=>x.ImageURL2).NotEmpty().WithMessage("Gorsel2 Alani bos gecilemez");
            RuleFor(x=>x.Price).NotEmpty().WithMessage("Fiyat Alani bos gecilemez");
            RuleFor(x=>x.Value).NotEmpty().WithMessage("Deger Alani bos gecilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adi en az 5 karakterden olusturmak zorundadir");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adi en fazla 100 karakterden olusturmak zorundadir");
        }
    }
}
