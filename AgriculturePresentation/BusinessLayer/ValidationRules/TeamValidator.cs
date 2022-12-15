using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Lütfen İsim Ve Soyismizi Giriniz.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz.");
            RuleFor(x => x.PersonName).MinimumLength(8).WithMessage("En az 8 karakter Girebilirsiniz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Görevinizi Giriniz.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter Girebilirsiniz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Lütfen Resminizi Yükleyiniz.");
        }
    }
}
