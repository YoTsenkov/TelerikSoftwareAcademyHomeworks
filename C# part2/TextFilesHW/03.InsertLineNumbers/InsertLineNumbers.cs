using System;
using System.Collections.Generic;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {

        string[] reader = File.ReadAllLines("text.txt");
        for (int i = 0; i < reader.Length; i++)
        {
            string lineNumber = (i + 1).ToString() + ". ";
            reader[i] = lineNumber + reader[i];
        }
        File.WriteAllLines("result.txt", reader);
        string[] result = File.ReadAllLines("result.txt");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

