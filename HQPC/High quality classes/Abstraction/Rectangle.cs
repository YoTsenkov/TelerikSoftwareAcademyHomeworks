﻿using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle()
            : this(0, 0)
        {
        }

        public Rectangle(double width, double height)            
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
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rectangle's width can't be less than zero.");
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
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rectangle's height can't be less than zero.");
                }

                this.height = value;                   
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
