using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


class MovingLetters
{
    static void Main()
    {
        string a = "abc def bugxcg    asdbh    naskjb g";
        MatchCollection matches = Regex.Matches(a, @"(\w\s+)|(\w$)", RegexOptions.None);
        foreach (var item in matches)
        {
            Console.WriteLine(item);
        }
    }
}

//@"(?<=\s+)|(?<=$)"

