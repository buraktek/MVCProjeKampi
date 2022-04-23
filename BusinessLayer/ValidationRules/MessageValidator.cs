using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı maili boş olamaz")
                .EmailAddress().WithMessage("Eposta adresi doğüru değil");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu kısmı boş olamaz")
                .MinimumLength(2).WithMessage("En az 2 karakter olmalıdır");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj kısmı boş olamaz")
                .MaximumLength(500).WithMessage("En fazla 500 karakter olmalıdır");
        }
    }
}
