using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "int":
            case "double": Console.WriteLine(double.Parse(input) + 1);
                break;
            case "string": Console.WriteLine(input + "*");
                break;
            default: Console.WriteLine("invalid input");
                break;
        }
    }
}

