using System;
using System.IO;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Logic
{
    public class App
    {
        public static async Task InvokeBugAsync(HttpClient _http)
        {
            try
            {
                XmlReader reader = XmlReader.Create(await _http.GetStreamAsync("https://winappmerit.azurewebsites.net/api/CorsProxy?feed=https://rss.nytimes.com/services/xml/rss/nyt/US.xml"));

                SyndicationFeed feed = SyndicationFeed.Load(reader);

                var att = feed.ElementExtensions.ReadElementExtensions<XElement>("pubDate", string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
        }
    }
}
