// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √(xb - xa)2 + (yb - ya)2

Console.Clear();

Console.WriteLine("Введите координату x 1-й точки:");
double firstX = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y 1-й точки:");
double firstY = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x 2-й точки:");
double secondX = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y 2-й точки:");
double secondY = double.Parse(Console.ReadLine());

double distAB = Math.Sqrt(Math.Pow(secondX - firstX , 2) + Math.Pow(secondY - firstY , 2));

Console.WriteLine();
Console.WriteLine("Расстояние между двух точек: " + distAB);