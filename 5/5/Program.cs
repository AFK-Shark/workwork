using _5;

var rectangle1 = new Rectangle<int, int>(4, 2, (0.0, 0.0));
Console.WriteLine("Прямоугольник 1:");
Console.WriteLine($"MinPoint: {rectangle1.MinPoint}");
Console.WriteLine($"MaxPoint: {rectangle1.MaxPoint}");
var rectangle2 = new Rectangle<float, float>(2.5f, 3.3f, (1.5, 2.5));
Console.WriteLine("\nПрямоугольник 2:");
Console.WriteLine($"MinPoint: {rectangle2.MinPoint}");
Console.WriteLine($"MaxPoint: {rectangle2.MaxPoint}");
var rectangle3 = new Rectangle<int, float>(3, 4.2f, (-2.0, 3.0));
Console.WriteLine("\nПрямоугольник 3:");
Console.WriteLine($"MinPoint: {rectangle3.MinPoint}");