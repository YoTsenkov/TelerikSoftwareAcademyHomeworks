namespace _6.ReadExcelWithOLEDB
{
    using System;
    using System.Data.OleDb;

    //for unknows reason it throws an exception saying it cant find Students
    //I have named both the table and the sheet Students so i couldnt figure it out
    //but the rest should be ok code
    public class ExcelAccessor
    {
        private static void AppendRow(string studentName, int score)
        {
            var dbCon = new OleDbConnection(Settings.Default.OLEDBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                var insertCommand = new OleDbCommand(
                    "INSERT INTO Students(Name, Score) VALUES (@name, @score)", dbCon);
                insertCommand.Parameters.AddWithValue("@name", studentName);
                insertCommand.Parameters.AddWithValue("@score", score);

                insertCommand.ExecuteNonQuery();
            }
        }

        static void Main(string[] args)
        {
            OleDbConnection dbCon = new OleDbConnection(Settings.Default.OLEDBConnectionString);
            dbCon.Open();
            using (dbCon)
            {
                AppendRow("Ivan", 66);
                OleDbCommand cmdExtractData = new OleDbCommand(
                    "SELECT * FROM Students", dbCon);
                
                OleDbDataReader reader = cmdExtractData.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        int score = (int)reader["Score"];
                        Console.WriteLine(name + " -> " + score);
                    }
                }
            }
        }
    }
}
