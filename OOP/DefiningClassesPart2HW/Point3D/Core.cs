using System;
using Library;

namespace Core
{
    class Core
    {
        static void Main()
        {
            Point3D point = new Point3D();
            point.X = 5;
            Console.WriteLine(point.ToString());

            Console.WriteLine(Point3D.StartCoordSys.ToString());


        }
    }
}
