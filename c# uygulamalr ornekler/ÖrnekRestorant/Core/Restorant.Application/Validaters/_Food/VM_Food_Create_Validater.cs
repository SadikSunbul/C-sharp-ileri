using FluentValidation;
using Microsoft.AspNetCore.Rewrite;
using Restorant.Application.ViewModel._Customer;
using Restorant.Application.ViewModel._Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Validaters._Food
{
    public class VM_Food_Create_Validater:AbstractValidator<VM_Food_Create>
    {
        public VM_Food_Create_Validater()
        {
            RuleFor(i => i.Name).NotEmpty().NotNull().WithMessage("İsim laanı boş brakılamaz");
            RuleFor(i => i.Exists).NotEmpty().NotNull().WithMessage("Bulunma alanı boş brakılamaz");
            RuleFor(i => i.Price).NotEmpty().NotNull().WithMessage("Fiyat laanı boş brakılamaz")
                .Must(i=>i>0).WithMessage("Fiyat 0 dan buyuk olmalıdır ");
            RuleFor(i => i.Description).NotEmpty().NotNull().WithMessage("Acıklama alanı boş brakılamaz");
           
        }
    }
}
