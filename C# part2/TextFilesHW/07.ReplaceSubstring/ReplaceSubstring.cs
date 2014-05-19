using System;
using System.Collections.Generic;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        //solution 1
        StreamReader reader = new StreamReader("input.txt");
        using (reader)
        {
            string[] file = File.ReadAllLines("input.txt");
            Console.WriteLine("Input file content :");
            foreach (var item in file)
            {
                Console.WriteLine(item);
            }
            string line;
            for (int i = 0; i < file.Length; i++)
            {
                line = reader.ReadLine();
                file[i] = line.Replace("start", "finish");
            }
            File.WriteAllLines("output.txt", file);
            string[] result = File.ReadAllLines("output.txt");
            Console.WriteLine("Replaced file content : ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        //solution 2
        //File.WriteAllText("output.txt", File.ReadAllText("input.txt").Replace("start", "finish"));
    }
}

