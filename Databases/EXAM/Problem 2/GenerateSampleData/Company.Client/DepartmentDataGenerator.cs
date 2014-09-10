namespace Company.Client
{
    using Company.Data;
    using System;
    using System.Linq;

    internal class DepartmentDataGenerator : IDataGenerator
    {
        private IRandomDataGenerator random;
        private CompanyEntities db;
        private int count;

        public DepartmentDataGenerator(IRandomDataGenerator randomDataGenerator, CompanyEntities companyEntities, int countOfgeneratedObjects)
        {
            this.random = randomDataGenerator;
            this.db = companyEntities;
            this.count = countOfgeneratedObjects;
        }
        public void Generate()
        {
            for (int i = 0; i < this.count; i++)
            {
                var department = new Department
                {
                    Name = this.random.GetRandomStringWithRandomLength(10, 50)
                };

                this.db.Departments.Add(department);

                if (i % 10 == 0)
                {
                    Console.WriteLine(".");
                    db.SaveChanges();
                }
            }
        }
    }
}
