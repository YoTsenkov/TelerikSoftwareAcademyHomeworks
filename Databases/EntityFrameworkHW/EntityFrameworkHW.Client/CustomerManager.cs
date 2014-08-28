namespace EntityFrameworkHW.Client
{
    using System;
    using System.Linq;    
    using EntityFrameworkHW.Data;
    using System.Collections.Generic;
    using System.Transactions;

    public static class CustomerManager
    {
        public static string InsertCustomer(NorthwindEntities northwindContext, string customerId, string companyName)
        {
                Customer customer = new Customer()
                {
                    CustomerID = customerId,
                    CompanyName = companyName
                };
                northwindContext.Customers.Add(customer);
                northwindContext.SaveChanges();

                return customer.CustomerID;            
        }

        public static void ModifyCustomerCompanyName(NorthwindEntities northwindContext, string customerId, string newCompanyName)
        {
                Customer customer = GetCustomerById(northwindContext, customerId);
                customer.CompanyName = newCompanyName;
                northwindContext.SaveChanges();            
        }

        public static void DeleteCustomer(NorthwindEntities northwindContext, string customerId)
        {
                Customer customer = GetCustomerById(northwindContext, customerId);
                northwindContext.Customers.Remove(customer);
                northwindContext.SaveChanges();            
        }

        public static ICollection<Customer> GetAllCustomersByOrderYearAndShippedCountry(int desiredOrderYear, string desiredShippedCountry)
        {
            NorthwindEntities northwindContext = new NorthwindEntities();
            ICollection<Customer> customers;
           
                customers = northwindContext.Orders.Where(o => o.OrderDate.Value.Year == desiredOrderYear)
                                                                .Where(o => o.ShipCountry == desiredShippedCountry)
                                                                .Select(o => o.Customer).Distinct().ToList();
                northwindContext.Database.Create();
               
            return customers;
        }

        public static void InsertTwoCustomersWithTransaction(NorthwindEntities northwindContext, string customerOneId, string customerOneCompanyName,
                                                            string customerTwoId, string customerTwoCompanyname)
        {
            
                using (TransactionScope transaction = new TransactionScope())
                {                    
                    
                        InsertCustomer(northwindContext, customerOneId, customerOneCompanyName);
                        InsertCustomer(northwindContext, customerTwoId, customerTwoCompanyname);

                        northwindContext.SaveChanges();
                        transaction.Complete();
                 
                }
                
            
        }

        private static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerId)
        {
            Customer customer = northwindEntities.Customers.FirstOrDefault(
                c => c.CustomerID == customerId);
            return customer;
        }

    }
}
