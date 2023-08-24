using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CustomConfigurationProvider;
internal class CustomConfigProvider : IConfigurationProvider
{
    private readonly CustomConfigService customConfigService;
    public CustomConfigProvider()
    {
        customConfigService = new CustomConfigService();
    }

    public void Set(string key, string value)
    {
        customConfigService.SetValue(key, value);
    }

    public bool TryGet(string key, out string value)
    {
        value = customConfigService.GetValue(key);
        return value is not null;
    }

    public IEnumerable<string> GetChildKeys(IEnumerable<string> earlierKeys, string parentPath)
    {
        return customConfigService.GetKeys();
    }

    public void Load()
    {
        
    }

    public IChangeToken GetReloadToken()
    {
        return new ConfigurationReloadToken();
    }
}
