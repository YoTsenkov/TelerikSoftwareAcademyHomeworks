using Company.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Client
{
    internal class ReportsDataGenerator : IDataGenerator
    {
        private IRandomDataGenerator random;
        private CompanyEntities db;
        private int count;

        public ReportsDataGenerator(IRandomDataGenerator randomDataGenerator, CompanyEntities companyEntities, int countOfgeneratedObjects)
        {
            this.random = randomDataGenerator;
            this.db = companyEntities;
            this.count = countOfgeneratedObjects;
        }

        public void Generate()
        {
            foreach (var employee in db.Employees)
            {
                //employee.Reports.Add()
            }
        }
    }
}
