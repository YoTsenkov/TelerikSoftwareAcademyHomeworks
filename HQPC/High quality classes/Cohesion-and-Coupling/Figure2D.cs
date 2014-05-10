namespace CohesionAndCoupling
{
    using System;

    public class Figure2D
    {
        private double width;
        private double height;

        public Figure2D()
            : this(0,0)
        { 
        }

        public Figure2D(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        { 
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width can't be less than zero.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height can't be less than zero.");
                }

                this.height = value;
            }
        }

        public virtual double CalcDiagonalXY()
        {
            double distance = GeometryOperations.CalcDistance2D(0, 0, Width, Height);

            return distance;
        }
    }
}
