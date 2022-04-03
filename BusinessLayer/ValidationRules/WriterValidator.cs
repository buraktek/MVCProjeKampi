using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar ismi boş olamaz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyismi boş olamaz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmı boş olamaz");
            //TODO: WriterAbout mutlaka a harfi içermeli koşulu ekle ödev
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter olmalıdır");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En az 2 karakter olmalıdır");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("En fazla 50 karakter olmalıdır");
            RuleFor(x => x.WriterTitle).MaximumLength(50).WithMessage("En fazla 50 karakter olmalıdır");
        }
    }
}
