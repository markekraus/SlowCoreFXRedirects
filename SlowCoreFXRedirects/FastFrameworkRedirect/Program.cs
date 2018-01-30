using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var httpHanler = new HttpClientHandler();
            var httpClient = new HttpClient(httpHanler);
            var result = httpClient.GetAsync("http://localhost:65479/api/Redirect/3").GetAwaiter().GetResult();
            var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            watch.Stop();
            result.Dispose();
            httpClient.Dispose();
            httpHanler.Dispose();
            Console.WriteLine($"Content: {content}");
            Console.WriteLine($"Milliseconds: {watch.ElapsedMilliseconds}");
        }
    }
}
