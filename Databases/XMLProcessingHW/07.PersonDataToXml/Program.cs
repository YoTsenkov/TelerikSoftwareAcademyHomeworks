using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07.PersonDataToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            string number;
            StreamReader reader = new StreamReader("../../person.txt");
            using (reader)
            {
                name = reader.ReadLine();
                address = reader.ReadLine();
                number = reader.ReadLine();
            }

            XDocument personXml = new XDocument(
                new XElement("person",
                    new XElement("name", name),
                    new XElement("address", address),
                    new XElement("phone-number", number)
                ));

            personXml.Save("../../person.xml");
        }
    }
}
