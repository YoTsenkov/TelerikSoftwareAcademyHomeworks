using System;
using System.Collections.Generic;
using System.IO;

class FillString
{
    static void Main()
    {
        Console.WriteLine("Enter a string with a maximum of 20 characters.");
        char[] input = new char[20];
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            input[i] = text[i];
        }
        if (text.Length < 20)
        {
            for (int i = text.Length; i < input.Length; i++)
            {
                input[i] = '*';
            }
        }
        Console.WriteLine(input);
    }
}

