using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("vuvedete a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("vuvedete b");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("vuvedete c");
        int c = int.Parse(Console.ReadLine());
        int discriminant = b * b - (4 * a * c);

        if (discriminant > 0)
        {
            Console.WriteLine("first real root -> {0}", (-b + Math.Sqrt(discriminant)) / 2 * a);
            Console.WriteLine("first real root -> {0}", (-b - Math.Sqrt(discriminant)) / 2 * a);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("there are no real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("the only real root is -> {0}", -b / 2 * a);
        }
    }
}

