namespace _04.DeleteAlbumsByPrice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../catalogue.xml");
            XmlNode rootNode = catalogue.DocumentElement;
            Console.WriteLine("Albums before deletion: " + rootNode.ChildNodes.Count);
            HashSet<XmlNode> childrenToBeRemoved = new HashSet<XmlNode>();
            foreach (XmlNode child in rootNode.ChildNodes)
            {
                if (decimal.Parse(child["price"].InnerText) > 20)
                {
                    childrenToBeRemoved.Add(child);
                }
            }

            foreach (var childToBeRemoved in childrenToBeRemoved)
            {
                rootNode.RemoveChild(childToBeRemoved);
            }

            Console.WriteLine("Albums after deletion: " + rootNode.ChildNodes.Count);
            catalogue.Save("../../../catalogue.xml");
        }
    }
}
