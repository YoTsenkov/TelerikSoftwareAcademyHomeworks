namespace EntityFrameworkHW.Client
{
    using System;
    using System.Linq;
    using EntityFrameworkHW.Data;
    using System.Collections.Generic;

    public class ClientTester
    {
        private static ICollection<Order> GetOrdersByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            NorthwindEntities northwindContext = new NorthwindEntities();
            ICollection<Order> orders = new HashSet<Order>();
            using (northwindContext)
            {
                foreach (var order in northwindContext.Orders.Where(o => o.ShipRegion == region)
                                                                .Where(o => o.OrderDate.Value > startDate)
                                                                .Where(o => o.OrderDate.Value < endDate))
                {
                    orders.Add(order);
                }

            }

            return orders;
        }

        static void Main()
        {
            NorthwindEntities northwindContext = new NorthwindEntities();            
            using (northwindContext)
            {
                //Task 2 tests
                // CustomerManager.ModifyCustomerCompanyName(northwindContext, "ANATR", "TELERIK");
                // CustomerManager.DeleteCustomer(northwindContext, "ALFKI");
                //CustomerManager.InsertCustomer(northwindContext, "rzyzz", "TELERIK");

                //Task 3 tester
                /*var customers = CustomerManager.GetAllCustomersByOrderYearAndShippedCountry(1997, "Canada");
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.ContactName);
                }*/

                //Task 5 tester
                /*DateTime startDate = new DateTime(1996,12,15);
                DateTime endDate = new DateTime(1998, 1, 1);
                var orders = GetOrdersByRegionAndPeriod("RJ", startDate, endDate);
                foreach (var order in orders)
                {
                    Console.WriteLine(order.OrderDate + " " + order.ShipRegion);
                }*/

                //Task 9 tests
                //CustomerManager.InsertTwoCustomersWithTransaction(northwindContext, "LELEL", "LOLOOL", "LOLOL", "LEELELE");
            }
            


        }
    }
}
