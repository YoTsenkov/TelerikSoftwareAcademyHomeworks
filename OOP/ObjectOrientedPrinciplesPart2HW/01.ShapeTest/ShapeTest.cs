using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

using ShapeLibrary;

namespace _01.ShapeTest
{
    class ShapeTest
    {
        static void Main()
        {
            var figures = new List<Shape>()
            {
                new Triangle(5,10),
                new Rectangle(5,10),
                new Circle(10,10)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.CalculateSurface());
            }
        }
    }
}
