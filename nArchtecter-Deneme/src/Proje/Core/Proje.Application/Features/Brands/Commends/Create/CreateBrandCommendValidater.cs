using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Commends.Create;

public class CreateBrandCommendValidater:AbstractValidator<CreateBrandCommandRespons>
{
    public CreateBrandCommendValidater()
    {
        RuleFor(i=>i.Name).NotEmpty().MinimumLength(2);//bos olamz ve min 2 uzunlugunda olmaldıır 

    }
}
