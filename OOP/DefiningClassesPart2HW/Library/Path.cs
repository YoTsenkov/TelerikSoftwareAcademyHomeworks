
namespace Library
{
    using System;
    using System.Collections.Generic;
    public class Path
    {
        public List<Point3D> path = new List<Point3D>();

        public Path()
        {
        }
        public Path(List<Point3D> path)
        {
            this.path = path;
        }

        public int Count
        {
            get
            {
                return path.Count;
            }
        }

        public void AddPoint(Point3D point)
        {
            path.Add(point);
        }

        public Point3D this [int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return path[index];
                }
            }
        }
    }
}
