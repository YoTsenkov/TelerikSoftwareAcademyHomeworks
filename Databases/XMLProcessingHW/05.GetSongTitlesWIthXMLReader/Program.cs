using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05.GetSongTitlesWIthXMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Song titles:");
            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
