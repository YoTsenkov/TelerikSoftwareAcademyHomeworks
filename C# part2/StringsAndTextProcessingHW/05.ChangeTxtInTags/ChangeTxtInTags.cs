using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ChangeTxtInTags
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        string input;
        using (reader)
        {
            input = reader.ReadToEnd();
        }
        input = Regex.Replace(input, @">(.|\n)*?<", match => match.Value.ToUpper());
        Console.WriteLine(input);
    }
}

