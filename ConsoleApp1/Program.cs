using GeometryClass;

double a = 3;
double b = 4;
double c = 5;
double radius = 5;

Console.WriteLine("Площадь круга: " + Math.Round(Circle.CSquare(radius), 2));
Console.WriteLine("\nПлощадь треугольника: " + Triangle.TSquare(a, b, c));
Console.WriteLine("\nПрямоугольный ли треугольник?: " + Triangle.TRight(a, b, c));