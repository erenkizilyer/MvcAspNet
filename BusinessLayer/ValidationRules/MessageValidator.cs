using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
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
             RuleFor(x=>x.RecevierMail).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsiniz.");
             RuleFor(x=>x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz.");
             RuleFor(x=>x.Subject).MaximumLength(100).WithMessage("Lütfen 100 Karakterden Fazla Değer girişi Yapmayın");
             RuleFor(x=>x.Subject).MaximumLength(100).WithMessage("Lütfen en az 3 Karakterden girin.");

        }

    
    }
}
