
namespace Library
{
    using System;
    using System.IO;
    static class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    for (int i = 0; i < path.Count; i++)
                    {
                        writer.WriteLine(path[i]);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Path LoadPath(string fileName)
        {
            Path path = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] splitted = line.Split(' ');
                        path.AddPoint(new Point3D(Convert.ToDecimal(splitted[0]), Convert.ToDecimal(splitted[1]), Convert.ToDecimal(splitted[2])));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return path;
        }
    }
}
