namespace CohesionAndCoupling
{
    using System;

    public class Figure3D : Figure2D
    {
        private double depth;

        public Figure3D()
            : this(0,0,0)
        {
        }

        public Figure3D(double width, double height, double depth)
            : base(width,height)
        {
            this.Depth = depth;
        }

        public double Depth
        { 
            get
            {
                return this.depth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Depth can't be less than zero.");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = GeometryOperations.CalcDistance3D(0, 0, 0, Width, Height, Depth);

            return distance;
        }        

        public double CalcDiagonalXZ()
        {
            double distance = GeometryOperations.CalcDistance2D(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = GeometryOperations.CalcDistance2D(0, 0, this.Height, this.Depth);

            return distance;
        }
    }
}
