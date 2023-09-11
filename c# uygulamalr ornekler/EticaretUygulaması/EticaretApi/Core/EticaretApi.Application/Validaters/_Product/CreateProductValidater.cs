using EticaretApi.Application.ViewModels.Products;
using EticaretApi.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Validaters._Product
{
    public class CreateProductValidater: AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidater()
        {
            RuleFor(c => c.Name).NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen ürün adını böş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Lütfen ürün adını 5 ila 150 karakter arasında giriniz.");

            RuleFor(p => p.Stock)
                .NotNull()
                .NotNull()
                    .WithMessage("Lütfen stock bilgisini boş geçmeyiniz.")
                .Must(s=>s>0)
                .WithMessage("Stock bilgisi 0 ve 0 dan küçük olamaz.");

            RuleFor(p => p.Price)
                .NotNull()
                .NotNull()
                    .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
                .Must(s => s > 0)
                .WithMessage("Fiyat bilgisi 0 ve 0 dan küçük olamaz.");
        }
    }
}
