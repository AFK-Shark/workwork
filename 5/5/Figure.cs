using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public abstract class Figure
    {
        public abstract (double, double) MinPoint { get; }
        public abstract (double, double) MaxPoint { get; }
    }
}
