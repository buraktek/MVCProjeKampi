using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresi boş olamaz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş olamaz");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Maximum uzunluk 50 olabilir");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı kısmı boş olamaz");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En az 3 karakter olmalıdır");
            RuleFor(x => x.Message).MinimumLength(10).WithMessage("En az 10 karakter olmalıdır");
        }
    }
}
