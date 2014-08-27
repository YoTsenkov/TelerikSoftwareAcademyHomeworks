namespace _5.ExtractAllImages
{
    using System;
    using System.Collections;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;

    public class ImageReriever
    {
        private const string DestImageFileName = @"..\..\logo-from-db.jpg";

        private static void WriteBinaryFile(string fileName,
            byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }

        private static int[] ListImageIdsFromDB()
        {
            SqlConnection dbConn = new SqlConnection(Settings.Default.SQLNorthwindConnectionString);
            dbConn.Open();
            using (dbConn)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT CategoryID FROM Categories", dbConn);
                ArrayList imageIds = new ArrayList();
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int imageId = (int)reader["CategoryID"];
                        imageIds.Add(imageId);
                    }
                }

                int[] imageIdArray = (int[])imageIds.
                    ToArray(typeof(int));
                return imageIdArray;
            }
        }

        private static void ExtractImageFromDB(int imageId, out byte[] image)
        {
            SqlConnection dbConn = new SqlConnection(
                Settings.Default.SQLNorthwindConnectionString);
            dbConn.Open();
            using (dbConn)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Picture FROM Categories " +
                    "WHERE CategoryID=@id", dbConn);
                SqlParameter paramId = new SqlParameter(
                    "@id", SqlDbType.Int);
                paramId.Value = imageId;
                cmd.Parameters.Add(paramId);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        image = (byte[])reader["Picture"];
                    }
                    else
                    {
                        throw new Exception(
                            String.Format("Invalid image ID={0}.", imageId));
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            int[] imageIds = ListImageIdsFromDB();
            Console.WriteLine("There are {0} images in the DB.",
                imageIds.Length);

            int firstImageId = imageIds[0];
            byte[] imageFromDB;
            ExtractImageFromDB(firstImageId,
                out imageFromDB);
            Console.WriteLine("Extracted first image from the DB.");

            WriteBinaryFile(DestImageFileName, imageFromDB);
            Console.WriteLine("Image saved to file {0}.",
                DestImageFileName);
        }
    }
}
