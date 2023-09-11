using FluentValidation;
using Restorant.Application.ViewModel._Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Validaters._Worker
{
    public class VM_Worker_Create_Valideter:AbstractValidator<VM_Worker_Create>
    {
        public VM_Worker_Create_Valideter()
        {
            RuleFor(i => i.Email).EmailAddress().WithMessage(" Mail formatına uygun degıl")
            .NotEmpty().NotNull().WithMessage("Mail boş geçilemez");
            RuleFor(i => i.Password).NotNull().NotEmpty().WithMessage("Şifre boş geçilemez")
                .MinimumLength(4).WithMessage("Şİfreniz en az 4 karakterli olmalıdır");
            RuleFor(i => i.Name).NotNull().NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(i => i.Surname).NotNull().NotEmpty().WithMessage("Soyisim boş geçilemez");
            RuleFor(i => i.Phone).NotNull().NotEmpty().WithMessage("telefon boş geçilemez");
            RuleFor(i => i.Addres).NotNull().NotEmpty().WithMessage("Addres boş geçilemez");
            RuleFor(i => i.Wage).NotNull().NotEmpty().WithMessage("Maaş boş geçilemez");
        }
    }
}
