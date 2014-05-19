using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWords
{
    static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");

        for (int i = 0; i < input.Length; i++)
        {
            //using regular expression
            input[i] = Regex.Replace(input[i], @"\bstart\b", "finish");
        }
        File.WriteAllLines("output.txt", input);
    }
}

