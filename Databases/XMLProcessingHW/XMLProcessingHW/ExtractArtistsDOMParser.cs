namespace XMLProcessingHW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    class ExtractArtistsDOMParser
    {
        static void Main(string[] args)
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../catalogue.xml");

            XmlNode rootNode = catalogue.DocumentElement;
            Dictionary<string, int> artistAlbums = new Dictionary<string, int>();
            foreach (XmlNode child in rootNode.ChildNodes)
            {
                if (artistAlbums.ContainsKey(child["artist"].InnerText))
                {
                    artistAlbums[child["artist"].InnerText]++;
                }
                else
                {
                    artistAlbums[child["artist"].InnerText] = 1;
                }
            }

            foreach (var artist in artistAlbums)
            {
                Console.WriteLine(artist.Key + " -> " + artist.Value + " albums");
            }
        }
    }
}
