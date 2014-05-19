using System;
class Point_Within_Circle
{
    static void Main()
    {
        int rad = 5;
        int x = 4;
        int y = 6;
        Console.WriteLine(((x * x + y * y) <= rad * rad) ? "The point is WITHIN the circle" : "The point is OUT of the circle");
    }
}

