using System;
class Program
{
    static void Main()
    {
        decimal a = int.Parse(Console.ReadLine());
        decimal b = int.Parse(Console.ReadLine());
        decimal c = int.Parse(Console.ReadLine());
        decimal d = int.Parse(Console.ReadLine());
        decimal piece = a / b + c / d;

        if (piece >= 1)
        {
            Console.WriteLine((int)piece);
            Console.WriteLine(a * d + c * b + "/" + b * d);
        }
        else if (piece < 1)
        {
            Console.WriteLine("{0:f20}", piece);
            Console.WriteLine(a * d + c * b + "/" + b * d);
        }

    }
}

