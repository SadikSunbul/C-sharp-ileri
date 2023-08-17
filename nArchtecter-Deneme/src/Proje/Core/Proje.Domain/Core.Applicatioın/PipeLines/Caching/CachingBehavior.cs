using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Applicatioın.PipeLines.Caching;

public class CachingBehavior<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons> where TRequest : IRequest<TRespons>, ICachableRequest
{
    private readonly CacheSettings _cacheSettings;//bızım yazdıgımız sınıf 
    private readonly IDistributedCache cache;  //Distirübit cache oratamlar saglıycak bıze 

    public CachingBehavior(IDistributedCache cache,IConfiguration configuration)
    {
        _cacheSettings = configuration.GetSection("CacheSettings").Get<CacheSettings>()??throw new InvalidOperationException();//default degerını okuduk appsettıngsten buradakı get ın gelmesı için Microsoft.Extensions.Configuration.Binder inmelidir
        this.cache = cache;
    }

    public async Task<TRespons> Handle(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {
        if (request.BypassCache)
        {
            return await next();//calıscak requestımız
        }
        TRespons respons;
        //cashler byt array olarak tutulur 
        byte[]? cacheRespons = await cache.GetAsync(request.CacheKey, cancellationToken);//gıt bak bakıyım varmı cashde bu neye gore cachekey e gore default cancelatıontoken
        if (cacheRespons != null)
        {
            //cashde var 
            respons = JsonSerializer.Deserialize<TRespons>(Encoding.Default.GetString(cacheRespons));
        }
        else
        {
            //cache yok ise git veritabanından oku ve bunu cachle ıslemı yapılır burada
            respons = await getResponseAndAddToCache(request, next, cancellationToken);
        }
        return respons;
    }

    private async Task<TRespons?> getResponseAndAddToCache(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {//VERI TABANINDAN DATAYI ALICAZ 
        TRespons respons = await next(); //burada handler kısmı calısır 

        TimeSpan slidingExpiration = request.SlidiExpiration ?? TimeSpan.FromDays(_cacheSettings.SlidingExpiration);//verılemmıs ıse default deger verıyoruz appsettingsten okuycagımız data

        DistributedCacheEntryOptions cacheOptions = new()
        {
            SlidingExpiration = slidingExpiration
        };

        byte[] seriliazdata = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(respons));

        await cache.SetAsync(request.CacheKey, seriliazdata, cacheOptions, cancellationToken);

        if(request.CavheGroupKey!=null)
            await addCacheKeyToGroup(request,slidingExpiration, cancellationToken);

        return respons;
    }

    private async Task addCacheKeyToGroup(TRequest request, TimeSpan slidingExpiration, CancellationToken cancellationToken)
    {
        byte[]? cacheGroupCache = await cache.GetAsync(key: request.CavheGroupKey!, cancellationToken);
        HashSet<string> cacheKeysInGroup;
        if (cacheGroupCache != null)
        {
            cacheKeysInGroup = JsonSerializer.Deserialize<HashSet<string>>(Encoding.Default.GetString(cacheGroupCache))!;
            if (!cacheKeysInGroup.Contains(request.CacheKey))
                cacheKeysInGroup.Add(request.CacheKey);
        }
        else
            cacheKeysInGroup = new HashSet<string>(new[] { request.CacheKey });
        byte[] newCacheGroupCache = JsonSerializer.SerializeToUtf8Bytes(cacheKeysInGroup);

        byte[]? cacheGroupCacheSlidingExpirationCache = await cache.GetAsync(
            key: $"{request.CavheGroupKey}SlidingExpiration",
            cancellationToken
        );
        int? cacheGroupCacheSlidingExpirationValue = null;
        if (cacheGroupCacheSlidingExpirationCache != null)
            cacheGroupCacheSlidingExpirationValue = Convert.ToInt32(Encoding.Default.GetString(cacheGroupCacheSlidingExpirationCache));
        if (cacheGroupCacheSlidingExpirationValue == null || slidingExpiration.TotalSeconds > cacheGroupCacheSlidingExpirationValue)
            cacheGroupCacheSlidingExpirationValue = Convert.ToInt32(slidingExpiration.TotalSeconds);
        byte[] serializeCachedGroupSlidingExpirationData = JsonSerializer.SerializeToUtf8Bytes(cacheGroupCacheSlidingExpirationValue);

        DistributedCacheEntryOptions cacheOptions =
            new() { SlidingExpiration = TimeSpan.FromSeconds(Convert.ToDouble(cacheGroupCacheSlidingExpirationValue)) };

        await cache.SetAsync(key: request.CavheGroupKey!, newCacheGroupCache, cacheOptions, cancellationToken);
        

        await cache.SetAsync(
            key: $"{request.CavheGroupKey}SlidingExpiration",
            serializeCachedGroupSlidingExpirationData,
            cacheOptions,
            cancellationToken
        );
        
    }
}

//Cached data 

//CacheGroupKey = cacheKeys[] 

//cashde cash anahtarı tutucak 