using Cor.CrossCuttingConcerns.Rules;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Proje.Application.PipeLines.Validation;
using Proje.Domain.Core.Applicatioın.PipeLines.Caching;
using Proje.Domain.Core.Applicatioın.PipeLines.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //Mediater ioc kaydını yapık 
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()); //tum dosyaları gez ve bul dedik

            configuration.AddOpenBehavior(typeof(RequestValidaterBehavior<,>)); //git bır request calsıtrcaksan burdan mıdel warede bır gecir
            //pıplınelerın devreye gırmesı ıcın yazıldı burası 

            configuration.AddOpenBehavior(typeof(TransactionScopeBehavior<,>));
            configuration.AddOpenBehavior(typeof(CachingBehavior<,>));
            configuration.AddOpenBehavior(typeof(ICacheRemowerRequest<,>));
        });

        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules)); //İş sınıflarımızı ekliyoeuz burada

        services.AddAutoMapper(Assembly.GetExecutingAssembly()); //oto mapper kaydı 

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());    //fuluent valıdater kaydı 


        return services;
    }
    /// <summary>
    /// servis extensinı 
    /// hangi assamblyde arıycak 
    /// ne arıycak girilcek ve 
    /// otomatik bir şekilde aram ayapıp ilgili kalıtılmıs vb lerı bulup ıoc ye eklıycektır 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="assembly"></param>
    /// <param name="type"></param>
    /// <param name="addWithLifeCycle"></param>
    /// <returns></returns>
    public static IServiceCollection AddSubClassesOfType(
     this IServiceCollection services,
     Assembly assembly,
     Type type,
     Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
    {
        //Asambly tıpınde bır arama yap 
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        //GetTypes() fonksiyonu, derleme içindeki tüm türleri döndürür.
        //türleri filtrelerken "type" adlı bir türün alt türü olanları seçer. Yani, "type" türünün alt türleri (miras alınan türler) seçilir. Örneğin, "type" bir "Person" türünü temsil ediyorsa, "Person" türünden türetilmiş alt türler seçilir.
        //type != t: Bu kısım, "type" türü ile "t" türünün aynı olmadığını kontrol eder. Bu, doğrudan "type" türünü dışlamak için kullanılır. Yani, "type" türü kendisini seçilmeyen türler arasına koymak için kullanılır. yanı type ın kendı degerını almaz içine

        foreach (var item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item); //gelen tıplerı tek tek ekleriz

            else
                addWithLifeCycle(services, type);
        return services;
    }

}

/*
 services.AddScoped(Car);     ----> ıoc den cekme ---> Car car ;deriz
services.AddScoped<ICar,Car>();  --->ıoc den cekme ---> ICar car ; deriz bu bize Car ı getirir,
 */
