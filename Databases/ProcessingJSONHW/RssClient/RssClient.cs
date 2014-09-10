namespace RssClient
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using Newtonsoft.Json.Linq;

    public class RssClient
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WebClient downloader = new WebClient();
            downloader.DownloadFile("http://forums.academy.telerik.com/feed/qa.rss", "rss.xml");

            XDocument rss = XDocument.Load("rss.xml");
            var serializedRss = JsonConvert.SerializeXNode(rss);
            var rssJson = JObject.Parse(serializedRss);
            /*var titles = rssJson["rss"]["channel"]["item"].Select(t => (string)t.SelectToken("title")).ToList();
            Console.WriteLine();*/
            /*var titles = rssJson.Descendants().OfType<JProperty>()
                .Where(tag => tag.Name == "title")
                .Select(title => title.Value);*/

            //printing the titles
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            /*var template = new
            {
                Title = ""
            };
            var rssPoco = JsonConvert.DeserializeAnonymousType(serializedRss, template);
            Console.WriteLine(rssPoco.Title);*/
        }
    }
}
