using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class CheckBreckets
{
    static void Main()
    {
        string expr = ")(a+b) * 5) / 2";
        MatchCollection one = Regex.Matches(expr, @"\(");
        MatchCollection two = Regex.Matches(expr, @"\)");
        if (one.Count == two.Count)
        {
            Console.WriteLine("The breckets are put correctly.");
        }
        else
        {
            Console.WriteLine("The breckets are NOT put correctly.");
        }
    }
}

