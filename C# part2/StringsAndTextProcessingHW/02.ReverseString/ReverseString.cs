using System;
using System.Collections.Generic;
using System.IO;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter the string to be reversed.");
        string input = Console.ReadLine();
        Console.WriteLine("The reversed string is : ");
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[input.Length - 1 - i]);
        }
        Console.WriteLine();
    }
}

