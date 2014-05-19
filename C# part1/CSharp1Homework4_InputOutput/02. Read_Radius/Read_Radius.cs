using System;
class Read_Radius
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter ={0}", 2 * 3.14 * r);
        Console.WriteLine("Area ={0}", 3.14 * r * r);
    }
}

