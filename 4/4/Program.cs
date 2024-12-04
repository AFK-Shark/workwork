using _4;
using System.Numerics;

Circle<int> circle1 = new Circle<int>(new Vector2(0, 0), 5);
circle1.SetRadius(10);
Console.WriteLine($"Круг 1: Радиус = {circle1.Radius}, Area = {circle1.Area}");
Circle<string> circle2 = new Circle<string>(new Vector2(1, 1), "7");
circle2.SetRadius("14");
Console.WriteLine($"Круг 2: Радиус = {circle2.Radius}, Area = {circle2.Area}");
Circle<double> circle3 = new Circle<double>(new Vector2(2, 2), 3.2);
circle3.SetRadius(4.5);
Console.WriteLine($"Круг 3: Радиус = {circle3.Radius}, Area = {circle3.Area}");
Circle<float> circle4 = new Circle<float>(new Vector2(3, 3), 2.4f);
circle4.SetRadius(3.1f);
Console.WriteLine($"Круг 4: Радиус = {circle4.Radius}, Area = {circle4.Area}");
