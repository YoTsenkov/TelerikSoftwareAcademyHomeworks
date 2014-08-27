namespace _1.RetrieveTheNumberOfCategoriesInNorthwind
{
    using System;
    using System.Data.SqlClient;

    public class CategoriesFinder
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(Settings.Default.SQLNorthwindConnectionString);
            dbCon.Open();        
            
            using (dbCon)
            {
                SqlCommand cmdCount = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories", dbCon);
                int categoriesCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("Categories count: {0} ", categoriesCount);
            }
        }
    }
}
