namespace ShapeLibrary
{
    using System;
    public class Circle : Shape
    {        
        public Circle(int width, int height)
        {
            this.width = width;
            this.Height = height;
        }

        public int Height 
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value != this.width)
                {
                    throw new ArgumentException("Invalid height. Must be equal to the width");
                }

                this.height = value;
            }
        }
        public override int CalculateSurface()
        {
            return (int)(Math.PI * Math.Pow(width / 2, 2));
        }
    }
}
