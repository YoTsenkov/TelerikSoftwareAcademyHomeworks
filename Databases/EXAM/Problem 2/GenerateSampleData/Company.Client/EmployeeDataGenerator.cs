namespace Company.Client
{
    using Company.Data;
    using System;
    using System.Linq;

    internal class EmployeeDataGenerator : IDataGenerator
    {
        private IRandomDataGenerator random;
        private CompanyEntities db;
        private int count;

        public EmployeeDataGenerator(IRandomDataGenerator randomDataGenerator, CompanyEntities companyEntities, int countOfgeneratedObjects)
        {
            this.random = randomDataGenerator;
            this.db = companyEntities;
            this.count = countOfgeneratedObjects;
        }
        public void Generate()
        {
            for (int i = 0; i < this.count; i++)
            {
                var employee = new Employee();
                employee.Department = new Department { Name = random.GetRandomStringWithRandomLength(10, 50) };
                employee.YearSalary = random.GetRandomNumber(20000, 50000);

                db.Employees.Add(employee);

                if (i % 100 == 0)
                {
                    Console.WriteLine(".");
                    db.SaveChanges();
                }
            }
        }
    }
}
