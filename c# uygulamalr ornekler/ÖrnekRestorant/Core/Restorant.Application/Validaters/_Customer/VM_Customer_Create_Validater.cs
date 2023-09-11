using FluentValidation;
using Restorant.Application.ViewModel._Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Validaters._Customer
{
    public class VM_Customer_Create_Validater:AbstractValidator<VM_Customer_Create>
    {
        public VM_Customer_Create_Validater()
        {
            RuleFor(i => i.Email).EmailAddress().WithMessage(" Mail formatına uygun degıl")
                .NotEmpty().NotNull().WithMessage("Mail boş geçilemez");
            RuleFor(i => i.Password).NotNull().NotEmpty().WithMessage("Şifre boş geçilemez")
                .MinimumLength(4).WithMessage("Şİfreniz en az 4 karakterli olmalıdır");
            RuleFor(i => i.İsim).NotNull().NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(i => i.Soyisim).NotNull().NotEmpty().WithMessage("Soyisim boş geçilemez");
            RuleFor(i => i.Phone).NotNull().NotEmpty().WithMessage("telefon boş geçilemez");

        }
    }
}
