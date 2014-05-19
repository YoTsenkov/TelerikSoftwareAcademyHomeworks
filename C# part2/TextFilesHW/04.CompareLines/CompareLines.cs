using System;
using System.Collections.Generic;
using System.IO;

class CompareLines
{
    static void Main()
    {
        string[] fileOne = File.ReadAllLines("fileOne.txt");
        string[] fileTwo = File.ReadAllLines("fileTwo.txt");
        Console.WriteLine("The content of the first file is :");
        foreach (var item in fileOne)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("The content of the second file is :");
        foreach (var item in fileTwo)
        {
            Console.WriteLine(item);
        }
        int differentLines = 0;
        int sameLines = 0;
        for (int i = 0; i < fileOne.Length; i++)
        {
            if (fileOne[i] == fileTwo[i])
            {
                sameLines++;
            }
            else
            {
                differentLines++;
            }
        }
        Console.WriteLine("The number of same lines is " + sameLines);
        Console.WriteLine("The number of different lines is " + differentLines);
    }
}

