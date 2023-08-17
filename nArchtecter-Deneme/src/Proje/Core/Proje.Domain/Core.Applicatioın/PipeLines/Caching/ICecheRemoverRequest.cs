using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Applicatioın.PipeLines.Caching;

public interface ICecheRemoverRequest
{
    string? CacheKey { get; } //isim olarak dusunule bılır
    bool BypassCache { get; }
    string? CacheGroupKey { get; }
}
