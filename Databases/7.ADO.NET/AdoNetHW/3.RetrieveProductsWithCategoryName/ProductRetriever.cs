namespace _3.RetrieveProductsWithCategoryName
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class ProductRetriever
    {
        static void Main()
        {
            var dbCon = new SqlConnection(Settings.Default.SQLNorthwindConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdGetProductNameAndCategory = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID ORDER BY c.CategoryName", dbCon);
                var productsList = new Dictionary<string, LinkedList<string>>();
                var reader = cmdGetProductNameAndCategory.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        if (productsList.ContainsKey(categoryName))
                        {
                            productsList[categoryName].AddLast(productName);
                        }
                        else
                        {
                            var newCategoryProducts =  new LinkedList<string>();
                            newCategoryProducts.AddFirst(productName);
                            productsList.Add(categoryName, newCategoryProducts);
                        }

                    }
                }

                foreach (var element in productsList)
                {
                    Console.WriteLine(element.Key + ": ");
                    foreach (var product in element.Value)
                    {
                        Console.Write(product + ", ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
