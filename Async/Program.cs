using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;
namespace Async
{
    class Program
    {
        static  async Task Main()
        {
           //Making breakfast
           
           //Make tea
           //- turn on burner(2sec)
           //- place kettle on burner(2sec)
           // -pour water(5sec)
           //- let it boil(5min)
           // -Grind masals(1min)
           //put suger and masalas(5s)
      
        HttpClient client = new HttpClient();
             Stopwatch stopwatch = Stopwatch.StartNew();
        var google = client. GetStringAsync("https://www.google.com/").Result;
        var micro = client. GetStringAsync("https://www.microsoft.com").Result;
        var yahoo = client. GetStringAsync("https://www.yahoo.com").Result;
        var github = client. GetStringAsync("https://www.github.com").Result;
        Console.WriteLine($"Time taken = {stopwatch.ElapsedMilliseconds}");

        stopwatch.Restart();
        var g = await client. GetStringAsync("https://www.google.com/");
        var m = await client. GetStringAsync("https://www.microsoft.com");
        var y = await client. GetStringAsync("https://www.yahoo.com");
        var gi = await client. GetStringAsync("https://www.github.com");
        Console.WriteLine($"Time taken = {stopwatch.ElapsedMilliseconds}");

        }
    }
}
