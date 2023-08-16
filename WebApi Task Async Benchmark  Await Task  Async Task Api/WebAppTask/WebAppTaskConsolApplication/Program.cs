


using System.Diagnostics;
using System.Runtime.CompilerServices;

do
{
    AddLog("App is running ....");

    Console.Write("Request Type (sync=0,async=1): ");
    int requesttype = int.Parse(Console.ReadLine());

    Console.Write("Haw many request");
    int requestCount = int.Parse(Console.ReadLine());

    WebApiClient webApiClient = new();

    var sv = Stopwatch.StartNew();//tımer baslatır bıze

    var tasks = requesttype == 0 ? GetSingTasks(requestCount) : GetAsingTasks(requestCount); //gelen degere gore bır asynmı syn mı ıstek  alınması lazzım onu belırledik burada

    // await tasks;//isteği bekledik
    await Task.WhenAll(tasks);//Bırden fazla task oldugu ıcın boyle yaptık 
    sv.Stop(); //tımer durdurulur
    AddLog($"Total Time :{sv.ElapsedMilliseconds} MS"); //bu kadar surdu der

} while (Console.ReadKey().Key == ConsoleKey.R); //burada bastıgımız tus R ıse basa doner


static IEnumerable<Task> GetSingTasks(int hawMandy)
{
    var result = new List<Task>();

    WebApiClient client = new();

    for (int i = 0; i < hawMandy; i++)
    {
        result.Add(client.CallSync());
    }
    return result;
}


static IEnumerable<Task> GetAsingTasks(int hawMandy)
{
    var result = new List<Task>();

    WebApiClient client = new();

    for (int i = 0; i < hawMandy; i++)
    {
        result.Add(client.CallAsync());
    }
    return result;
}

static void AddLog(string logstr)
{
    logstr = $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} - {logstr}";
    Console.WriteLine(logstr);
}


class WebApiClient
{
    private const string uri = "http://localhost:5100/api/test/";

    public async Task CallAsync()
    {
        HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(uri)
        };
        await client.GetAsync("async");
    }

    public async Task CallSync()
    {
        HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(uri)
        };
        await client.GetAsync("sync");
    }
}