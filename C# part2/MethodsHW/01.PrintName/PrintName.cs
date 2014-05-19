using System;
class PrintName
{
    static void Name()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0} !", name);
    }
    static void Main()
    {
        Name();
    }
}

