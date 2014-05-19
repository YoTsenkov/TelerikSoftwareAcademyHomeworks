using System;
class SurfOfTriangle
{
    static void SurfaceAltitude(int side, int altitude)
    {
        Console.WriteLine(Math.BigMul(side, altitude) / 2);
    }
    static void SurfaceSides(int a, int b, int c)
    {
        int p = (a + b + c) / 2;
        Console.WriteLine(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }
    static void SurfaceAngle(int a, int b, int angle)
    {
        Console.WriteLine((a * b * Math.Sin(angle)) / 2);
    }
    static void Main()
    {
        SurfaceAltitude(14, 10);
        SurfaceSides(8, 9, 11);
        SurfaceAngle(5, 7, 45);
    }
}

