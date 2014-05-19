using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class StringOccurances
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        string input;
        using (reader)
        {
            input = reader.ReadToEnd();            
        }
        MatchCollection result = Regex.Matches(input.ToLower(), @"in");
        Console.WriteLine("The result is : " + result.Count);
    }
}

