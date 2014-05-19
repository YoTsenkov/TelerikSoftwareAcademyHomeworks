using System;
using System.IO;
class ReadOddLines
{
    static void Main()
    {               
        string[] lines = File.ReadAllLines("text.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}

