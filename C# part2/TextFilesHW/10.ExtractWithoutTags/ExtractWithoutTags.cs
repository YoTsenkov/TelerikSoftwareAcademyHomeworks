using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ExtractWithoutTags
{
    static void Main()
    {     
        StreamReader reader = new StreamReader("input.txt");
        string input;
        using (reader)
        {
            input = reader.ReadToEnd();
        }
        input = Regex.Replace(input, @"<(.|\n)*?>", string.Empty);
        Console.WriteLine("The text without the tags is : ");
        Console.WriteLine(input);
    }
}

