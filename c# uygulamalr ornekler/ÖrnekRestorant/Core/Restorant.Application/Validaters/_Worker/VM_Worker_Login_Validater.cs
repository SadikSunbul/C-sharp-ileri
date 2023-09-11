using FluentValidation;
using Restorant.Application.ViewModel._Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Validaters._Worker
{
    public class VM_Worker_Login_Validater:AbstractValidator<VM_Worker_Login>
    {
        public VM_Worker_Login_Validater()
        {
            RuleFor(i => i.Email).EmailAddress().WithMessage(" Mail formatına uygun degıl")
           .NotEmpty().NotNull().WithMessage("Mail boş geçilemez");
            RuleFor(i => i.Password).NotNull().NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
