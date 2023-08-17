using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Applicatioın.PipeLines.Caching;

public class ICacheRemowerRequest<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons> where TRequest : IRequest<TRespons>, ICecheRemoverRequest
{
    private readonly IDistributedCache cache;

    public ICacheRemowerRequest(IDistributedCache cache)
    {
        this.cache = cache;
    }

    public async Task<TRespons> Handle(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {
        if (request.BypassCache)
        {
            return await next();
        }

        TRespons respons = await next();

        if (request.CacheGroupKey != null)
        {
            byte[]? cachedGroup = await cache.GetAsync(request.CacheGroupKey, cancellationToken);

            if (cachedGroup != null) // CACHDEKI LISTEYI BUL 
            {
                HashSet<string> keysInGroup = JsonSerializer.Deserialize<HashSet<string>>(Encoding.Default.GetString(cachedGroup))!;
                foreach (string key in keysInGroup)
                {
                    await cache.RemoveAsync(key, cancellationToken);
                }

                await cache.RemoveAsync(request.CacheGroupKey, cancellationToken);
                await cache.RemoveAsync(key: $"{request.CacheGroupKey}SlidingExpiration", cancellationToken);
            }
        }

        if (request.CacheKey != null)
        {
            await cache.RemoveAsync(request.CacheKey, cancellationToken);
        }

        return respons;
    }
}
