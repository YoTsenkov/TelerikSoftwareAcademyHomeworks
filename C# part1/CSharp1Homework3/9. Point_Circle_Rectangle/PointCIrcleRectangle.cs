using System;
class Point_Circle_Rectangle
{
    static void Main()
    {
        int rad = 3;
        int x = 4;
        int y = 6;
        if ((((x - 1) * (x - 1) + (y - 1) * (y - 1) <= rad * rad)) && x > -1 && x < 5 && y > 1 && y < -1)
        {
            Console.WriteLine("the point is within the circle and out of the rectangle");
        }

    }
}

