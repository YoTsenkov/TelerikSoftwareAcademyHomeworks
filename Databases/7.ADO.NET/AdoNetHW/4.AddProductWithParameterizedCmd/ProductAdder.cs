namespace _4.AddProductWithParameterizedCmd
{
    using System;
    using System.Data.SqlClient;

    public class ProductAdder
    {
        private static void InsertProduct(string productName, int supplierId, int categoryId,
            string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder,
            int reorderLevel, bool discontinued)
        {
            var dbCon = new SqlConnection(Settings.Default.SQLNorthwindConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Products " +
                      "(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, " +
                      "UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES " +
                      "(@name, @supplier, @category, @quantity, @price, @unitsInStock, " +
                      "@unitsOnOrder, @reorderLevel, @discontinued)", dbCon);
                cmd.Parameters.AddWithValue("@name", productName);
                cmd.Parameters.AddWithValue("@supplier", supplierId);
                cmd.Parameters.AddWithValue("@category", categoryId);
                cmd.Parameters.AddWithValue("@quantity", quantityPerUnit);
                cmd.Parameters.AddWithValue("@price", unitPrice);
                cmd.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                cmd.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                cmd.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                cmd.Parameters.AddWithValue("@discontinued", discontinued);

                cmd.ExecuteNonQuery();
            }

        }

        static void Main(string[] args)
        {
            InsertProduct("TESTPRODUCT", 6, 6, "Much x One", 6666, 6, 6, 6, true);
        }
    }
}
