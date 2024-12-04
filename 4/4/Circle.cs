using System.Numerics;

namespace _4
{
    public class Circle<T> : Figure
    {
        public T Radius { get; set; }

        public Circle(Vector2 center, T radius) : base(center)
        {
            Radius = radius;
        }

        public void SetRadius(T radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get
            {
                double radius = Convert.ToDouble(Radius);
                return radius * radius;
            }
        }
    }
}
