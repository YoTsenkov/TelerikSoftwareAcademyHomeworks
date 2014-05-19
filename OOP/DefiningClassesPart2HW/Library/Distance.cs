

namespace Library
{
    using System;
    public static class Distance
    {
        public static decimal GetDistance(Point3D firstPoint, Point3D secondPoint)
        {
            return (int)Math.Sqrt(Math.Pow((double)(secondPoint.X - firstPoint.X), 2) + Math.Pow((double)(secondPoint.Y - firstPoint.Y), 2) + Math.Pow((double)(secondPoint.Z - firstPoint.Z), 2));
        }
    }
}
