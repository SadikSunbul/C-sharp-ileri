using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Cars.Command.Create;

public class CreateCarCommandValidator:AbstractValidator<CreateCarCommandRequest>
{
    public CreateCarCommandValidator()
    {
        RuleFor(c => c.Model).NotEmpty().MinimumLength(2).WithMessage("Model boş ve 2 karakterden az olamaz");
    }
}
