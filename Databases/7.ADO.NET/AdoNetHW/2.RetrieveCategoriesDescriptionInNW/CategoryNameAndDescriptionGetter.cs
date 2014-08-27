namespace _2.RetrieveCategoriesDescriptionInNW
{
    using System;
    using System.Data.SqlClient;

    public class CategoryNameAndDescriptionGetter
    {
        static void Main(string[] args)
        {

            SqlConnection dbCon = new SqlConnection(Settings.Default.SQLNorthwindConnectionString);
            dbCon.Open();
            using (dbCon)
            {

                Console.WriteLine("Category name and description:");
                Console.WriteLine();
                SqlCommand cmdGetCategories = new SqlCommand(
                  "SELECT c.CategoryName, c.Description FROM Categories c", dbCon);
                SqlDataReader reader = cmdGetCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string Name = (string)reader["CategoryName"];
                        string Description = (string)reader["Description"];
                        Console.WriteLine("{0} -> {1}", Name, Description);
                    }
                }
            }
        }
    }
}
