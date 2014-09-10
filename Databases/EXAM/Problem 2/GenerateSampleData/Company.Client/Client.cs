namespace Company.Client
{
    using Company.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    internal class Client
    {
        private static void Main()
        {
            var random = RandomDataGenerator.Instance;
            var companyEntities = new CompanyEntities();

            //PROBLEM 2 Populating the DB
            /*using (companyEntities)
            {
                var listOfGenerators = new List<IDataGenerator>()
                {
                    new DepartmentDataGenerator(random, companyEntities, 100)
                };

                foreach (var generator in listOfGenerators)
                {
                    generator.Generate();
                    companyEntities.SaveChanges();
                }
            }*/

           
        }
    }
}
