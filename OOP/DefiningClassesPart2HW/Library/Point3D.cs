
namespace Library
{
    using System.Text;
    public struct Point3D
    {
        private static readonly Point3D startCoordSys = new Point3D(0, 0, 0);
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }

        public Point3D(decimal x, decimal y, decimal z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartCoordSys
        {
            get
            {
                return startCoordSys;
            }
        }

        public new string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("The X coordinate is " + X + "\n");
            result.Append("The Y coordinate is " + Y + "\n");
            result.Append("The Z coordinate is " + Z + "\n");
            return result.ToString();
        }
    }
}
