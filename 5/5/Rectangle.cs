using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Rectangle<TWidth, THeight> : Figure
    {
        public TWidth Width { get; set; }
        public THeight Height { get; set; }
        public (double, double) Center { get; set; }

        public Rectangle(TWidth width, THeight height, (double, double) center)
        {
            Width = width;
            Height = height;
            Center = center;
        }

        public override (double, double) MinPoint
        {
            get
            {
                var minX = Convert.ToDouble(Center.Item1) - Convert.ToDouble(Width) / 2;
                var minY = Convert.ToDouble(Center.Item2) - Convert.ToDouble(Height) / 2;
                return (minX, minY);
            }
        }

        public override (double, double) MaxPoint
        {
            get
            {
                var maxX = Convert.ToDouble(Center.Item1) + Convert.ToDouble(Width) / 2;
                var maxY = Convert.ToDouble(Center.Item2) + Convert.ToDouble(Height) / 2;
                return (maxX, maxY);
            }
        }
    }
}
