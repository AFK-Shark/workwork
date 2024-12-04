using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Circle : Rectangle<int, int>
    {
        public Circle(int width, int height, (double, double) center)
            : base(width, height, center) { }

        public override (double, double) MinPoint
        {
            get
            {
                var radius = Math.Min(Convert.ToDouble(Width), Convert.ToDouble(Height)) / 2;
                var minX = Convert.ToDouble(Center.Item1) - radius;
                var minY = Convert.ToDouble(Center.Item2) - radius;
                return (minX, minY);
            }
        }

        public override (double, double) MaxPoint
        {
            get
            {
                var radius = Math.Min(Convert.ToDouble(Width), Convert.ToDouble(Height)) / 2;
                var maxX = Convert.ToDouble(Center.Item1) + radius;
                var maxY = Convert.ToDouble(Center.Item2) + radius;
                return (maxX, maxY);
            }
        }
    }
}
