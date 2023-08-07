using Application.Features.Brands.Constants;

using Cor.CrossCuttingConcerns.Exceptions.Types;
using Cor.CrossCuttingConcerns.Rules;

using Proje.Application.Services.Repository;
using Proje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Rules;

public class BrandBusinessRules : BaseBusinessRules
{
    private readonly ICarRepository carRepository;

    public BrandBusinessRules(ICarRepository carRepository)
    {
        this.carRepository = carRepository;
    }

    /// <summary>
    /// Bu methodun kullanıldıgı yerde Araba Markası için bir kontrol saglar bu Marka varmı kontrolu yapar var ise hata veriri
    /// </summary>
    /// <param name="marka"></param>
    /// <returns></returns>
    /// <exception cref="BusinessException"></exception>
    public async Task BrandNameConnotBeDuplicatedWhenInserted(string marka)
    {
        Car? result = await carRepository.GetAsync(predicate: i => i.Marka.ToLower() == marka.ToLower());

        if (result != null)
        {//boyle bır kayt var ise
            throw new BusinessException(BrandMessages.BrandNameExists);//iş hatasıdır bu 
        }

    }
}
