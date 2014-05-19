using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne
{
    public class Display
    {       
        public Display()
        {            
        }
        public Display(double size)
        {
            this.Size = size;            
        }
        public Display(double size, int colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double? Size { get; set; }
        public int? Colors { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Display size: " + Size + "\n");
            result.Append("Display number of colors: " + Colors + "\n");

            return result.ToString();
        }
    }
}
