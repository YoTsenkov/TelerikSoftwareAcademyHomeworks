namespace _02.TraverseDirectories
{
    using System;
    using System.Collections.Generic;
    using System.IO;  
    using System.Security.AccessControl;

    public class TraverseDirectories
    {      
        public static IList<string> TraverseDirs(string path)
        {
            IList<string> exeFiles = new List<string>();
            
            try
            {
                var currentFiles = Directory.GetFiles(path);
                var currentDirs = Directory.GetDirectories(path);
                foreach (var file in currentFiles)
                {
                    if (file.EndsWith(".exe"))
                    {
                        //Due to the time it takes to get all .exe files i have weakened the coupling
                        //by adding direct printing on the consoel so immediate result is presented for
                        //easier testing
                        Console.WriteLine(file);
                        exeFiles.Add(file);
                    }
                }

                foreach (var dir in currentDirs)
                {                    
                    TraverseDirs(dir);
                }
            }
            catch (Exception)
            {

            }
           

            return exeFiles;
        }

        static void Main()
        {
            //the directories who doesnt provide access are skipped
            var exeFiles = TraverseDirs(@"C:\WINDOWS");           
        }
    }
}
