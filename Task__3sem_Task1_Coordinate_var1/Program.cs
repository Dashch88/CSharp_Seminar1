// Задача 1.
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// 1 -> x > 0, y > 0
// 3 -> x < 0, y < 0

Console.Clear();

Console.WriteLine("Введите номер четверти координатной плоскости.");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 4)
{
    Console.WriteLine("Вы ввели что-то другое!");
}
else
{
    if (num == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    if (num == 2)
    {
        Console.WriteLine("x < 0, y > 0");
    }
    if (num == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    if (num == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
}