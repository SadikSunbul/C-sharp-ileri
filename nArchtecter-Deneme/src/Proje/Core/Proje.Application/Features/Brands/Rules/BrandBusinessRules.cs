using Cor.CrossCuttingConcerns.Exceptions.Types;
using Cor.CrossCuttingConcerns.Rules;
using Proje.Application.Features.Brands.Constants;
using Proje.Application.Services.Repository;
using Proje.Domain.Core.Persistance.Repositories;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Features.Brands.Rules;

public class BrandBusinessRules: BaseBusinessRules
{
    private readonly IBrandRepository brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        this.brandRepository = brandRepository;
    }

    public async Task BrandNameConnotBeDuplicatedWhenInserted(string name)
    {
        Brand? result = await brandRepository.GetAsync(predicate: i => i.Name.ToLower() == name.ToLower());

        if (result != null)
        {//boyle bır kayt var ise
            throw new BusinessException(BrandMessages.BrandNameExists);//iş hatasıdır bu 
        }

    }
}
