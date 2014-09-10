namespace Cars.Client
{
    using Cars.Data;
    using Cars.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    internal static class CarQueriesProccessor
    {
        public static void ProccessQueriesFromXml(CarsDbContext context, string fileName)
        {
            XDocument source = XDocument.Load(fileName);
            var queries = source.Descendants("Query");
            var xmlResult = new XElement("Cars");
            foreach (var query in queries)
            {
                string outputFileName = query.Attribute("OutputFileName").Value;
                var orderClausesList = new HashSet<string>();
                foreach (var orderClause in query.Descendants("OrderBy"))
                {
                    orderClausesList.Add(orderClause.Value);
                }


                var whereClausesList = new Dictionary<KeyValuePair<string, string>, string>();
                foreach (var whereClause in query.Descendants("WhereClauses").Descendants("WhereClause"))
                {
                    string propertyName = whereClause.Attribute("PropertyName").Value;
                    string type = whereClause.Attribute("Type").Value;
                    whereClausesList.Add(new KeyValuePair<string, string>(propertyName, whereClause.Value), type);
                }

                var queryResults = context.Cars.AsQueryable();
                foreach (var whereClause in whereClausesList)
                {
                    string propertyName = whereClause.Key.Key;
                    string propertyValue = whereClause.Key.Value;
                    string type = whereClause.Value;
                    switch (propertyName)
                    {
                        case "Id":
                            if (type == "Equals")
                            {
                                queryResults.Where(c => c.CarId == int.Parse(propertyValue));
                            }
                            else if (type == "GreaterThan")
                            {
                                queryResults.Where(c => c.CarId > int.Parse(propertyValue));
                            }
                            else if (type == "LessThan")
                            {
                                queryResults.Where(c => c.CarId < int.Parse(propertyValue));
                            }                            
                            break;
                        case "City":
                            queryResults.Where(c => c.Dealer.Cities.Any(city => city.Name == propertyValue));                            
                            break;
                        case "Year":
                            if (type == "Equals")
                            {
                                queryResults.Where(c => c.Year == int.Parse(propertyValue));
                            }
                            else if (type == "GreaterThan")
                            {
                                queryResults.Where(c => c.Year > int.Parse(propertyValue));
                            }
                            else if (type == "LessThan")
                            {
                                queryResults.Where(c => c.Year < int.Parse(propertyValue));
                            }                            
                            break;
                        case "Price":
                            if (type == "Equals")
                            {
                                queryResults.Where(c => c.Price == decimal.Parse(propertyValue));
                            }
                            else if (type == "GreaterThan")
                            {
                                queryResults.Where(c => c.Price > decimal.Parse(propertyValue));
                            }
                            else if (type == "LessThan")
                            {
                                queryResults.Where(c => c.Price < decimal.Parse(propertyValue));
                            }                            
                            break;
                        case "Model":
                            queryResults.Where(c => c.Model == propertyValue);
                            break;
                        case "Manufacturer":
                            queryResults.Where(c => c.Manufacturer.Name == propertyValue);
                            break;
                        case "Dealer":
                            queryResults.Where(c => c.Dealer.Name == propertyValue);
                            break;
                        default:
                            break;
                    }
                }

                foreach (var orderClause in orderClausesList)
                {
                    switch (orderClause)
                    {
                        case "Id":
                            queryResults.OrderBy(c => c.CarId);
                            break;
                        case"Year":
                            queryResults.OrderBy(c => c.Year);
                            break;
                        case "Model":
                            queryResults.OrderBy(c => c.Model);
                            break;
                        case "Price":
                            queryResults.OrderBy(c => c.Price);
                            break;
                        case "Manufacturer":
                            queryResults.OrderBy(c => c.Manufacturer.Name);
                            break;
                        case "Dealer":
                            queryResults.OrderBy(c => c.Dealer.Name);
                            break;
                        default:
                            break;
                    }
                }

                var resultCarSet = queryResults.Select(c => 
                    new
                    {
                        Manufacturer = c.Manufacturer.Name,
                        Model = c.Model,
                        Year = c.Year,
                        Price = c.Price,
                        Transmisssion = c.TransmissionType,
                        Dealer = new
                        {
                            Name = c.Dealer.Name,
                            Cities = c.Dealer.Cities
                        }
                    }).ToList();

                foreach (var car in resultCarSet)
                {
                    var xmlCar = new XElement("Car");
                    xmlCar.SetAttributeValue("Manufacturer", car.Manufacturer);
                    xmlCar.SetAttributeValue("Model", car.Model);
                    xmlCar.SetAttributeValue("Year", car.Year);
                    xmlCar.SetAttributeValue("Price", car.Price);

                    var xmlTransmission = new XElement("TransmissionType", car.Transmisssion);
                    xmlCar.Add(xmlTransmission);

                    var xmlDealer = new XElement("Dealer");
                    xmlDealer.SetAttributeValue("Name", car.Dealer.Name);
                    var xmlDeaperCities = new XElement("Cities");
                    foreach (var city in car.Dealer.Cities)
                    {
                        var xmlCity = new XElement("City", city.Name);
                        xmlDeaperCities.Add(xmlCity);
                    }
                    xmlDealer.Add(xmlDeaperCities);
                    xmlCar.Add(xmlDealer);

                    xmlResult.Add(xmlCar);
                }

                xmlResult.Save(outputFileName);
            }
        }
    }
}
