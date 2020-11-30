using System;
using System.Linq;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var http = new HttpClient();

            await Logic.App.InvokeBugAsync(http);
        }
    }
}
