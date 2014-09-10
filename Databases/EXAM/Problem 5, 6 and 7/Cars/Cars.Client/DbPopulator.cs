namespace Cars.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cars.Data;
    using Cars.Models;
    using Newtonsoft.Json;
    using System.IO;
    using Newtonsoft.Json.Linq;


    internal static class DbPopulator
    {
        private static Manufacturer GetManufacturerByName(CarsDbContext context, string name)
        {
            Manufacturer manufacturer = context.Manufacturers.Where(m => m.Name == name).FirstOrDefault();
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { Name = name };
            }

            return manufacturer;
        }

        private static City GetCityByName(CarsDbContext context, string name)
        {
            City city = context.Cities.Where(c => c.Name == name).FirstOrDefault();
            if (city == null)
            {
                city = new City() { Name = name };
            }

            return city;
        }

        public static void PopulateFromJsonFile(CarsDbContext context, string jsonFileName)
        {
            StreamReader reader = new StreamReader(jsonFileName);
            JsonTextReader jsonReader = new JsonTextReader(reader);
            JsonSerializer jsonSerializer = new JsonSerializer();
            var parsedData = jsonSerializer.Deserialize(jsonReader).ToString();
            var carsArray = JArray.Parse(parsedData);

            foreach (var car in carsArray)
            {
                var newCar = new Car();
                newCar.Year = int.Parse((string)car["Year"]);
                newCar.TransmissionType = ((TransmissionTypes)(int.Parse((string)car["TransmissionType"]))).ToString();
                newCar.Manufacturer = GetManufacturerByName(context, (string)car["ManufacturerName"]);
                newCar.Model = (string)car["Model"];
                newCar.Price = decimal.Parse((string)car["Price"]);
                var dealer = new Dealer() { Name = (string)car["Dealer"]["Name"] };
                dealer.Cities.Add(GetCityByName(context, (string)car["Dealer"]["City"]));
                newCar.Dealer = dealer;

                context.Cars.Add(newCar);
                context.SaveChanges();
            }            
        }
    }
}
