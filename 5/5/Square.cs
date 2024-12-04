using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Square : Rectangle<int, int>
    {
        public Square(int width, int height, (double, double) center)
            : base(width, height, center) { }

        public override (double, double) MinPoint
        {
            get
            {
                var side = Math.Min(Convert.ToDouble(Width), Convert.ToDouble(Height));
                var minX = Convert.ToDouble(Center.Item1) - side / 2;
                var minY = Convert.ToDouble(Center.Item2) - side / 2;
                return (minX, minY);
            }
        }

        public override (double, double) MaxPoint
        {
            get
            {
                var side = Math.Min(Convert.ToDouble(Width), Convert.ToDouble(Height));
                var maxX = Convert.ToDouble(Center.Item1) + side / 2;
                var maxY = Convert.ToDouble(Center.Item2) + side / 2;
                return (maxX, maxY);
            }
        }
    }
}
