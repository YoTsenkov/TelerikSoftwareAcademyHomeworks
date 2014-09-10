using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _06.GetTitlesXDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument catalogue = XDocument.Load("../../../catalogue.xml");


            var titles =
                from album in catalogue.Descendants("album")
                from song in album.Descendants("song")
                select song.Element("title").Value;
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
            
        }
    }
}
