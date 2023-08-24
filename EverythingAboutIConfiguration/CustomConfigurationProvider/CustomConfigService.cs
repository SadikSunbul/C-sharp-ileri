namespace CustomConfigurationProvider;
internal class CustomConfigService
{
    // Temporary
    private Dictionary<string, string> configs = new(StringComparer.OrdinalIgnoreCase)
    {
        {"Database:Name", "Name From ConfigService" },
        {"Database:UserName", "UserName From ConfigService" }
    };

    public IEnumerable<string> GetKeys() 
    { 
        return configs.Keys; 
    }

    public void SetValue(string key, string value)
    {
        // Make service call

        var currentConfig = GetValue(key);

        if (currentConfig is null)
            configs.Add(key, value);
        else
            configs[key] = value;
    }

    public string GetValue(string key)
    {
        configs.TryGetValue(key, out string value);
        return value;
    }
}