using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string[] originalFile = new string[] { "Line 1", "Line 2", "Line 3", "Line 4", "Line 5" };
        Console.WriteLine("Starting text.txt content :");
        foreach (var item in originalFile)
        {
            Console.WriteLine(item);
        }
        File.WriteAllLines("text.txt", originalFile);
        string[] input = File.ReadAllLines("text.txt");
        string[] result = new string[input.Length / 2 + 1];
        List<string> buff = new List<string>();
        buff.AddRange(input);
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 1)
            {
                result[index] = input[i];
                index++;
            }
        }

        buff.Add("\n");
        buff.Add("Result written in the same file :");
        buff.Add("\n");
        buff.AddRange(result);
        File.WriteAllLines("text.txt", buff.ToArray());
        Console.WriteLine("New text.txt content :");
        foreach (var item in buff)
        {
            Console.WriteLine(item);
        }
    }
}

