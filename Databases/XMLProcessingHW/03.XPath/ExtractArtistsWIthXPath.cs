using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _03.XPath
{
    class ExtractArtistsWIthXPath
    {
        static void Main(string[] args)
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../catalogue.xml");
            string xPathQuery = "/catalogue/album/artist";
            var artists = catalogue.SelectNodes(xPathQuery);
            Dictionary<string, int> artistAlbums = new Dictionary<string, int>();
            foreach (XmlNode artist in artists)
            {
                if (artistAlbums.ContainsKey(artist.InnerText))
                {
                    artistAlbums[artist.InnerText]++;
                }
                else
                {
                    artistAlbums[artist.InnerText] = 1;
                }
            }

            foreach (var item in artistAlbums)
            {
                Console.WriteLine(item.Key + " -> " + item.Value + " albums");
            }
        }
    }
}
