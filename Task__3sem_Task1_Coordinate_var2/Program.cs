// Задача 1.
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// 1 -> x > 0, y > 0
// 3 -> x < 0, y < 0

// через switch

Console.Clear();

Console.WriteLine("Введите номер четверти координатной плоскости.");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;

    default:
        Console.WriteLine("Вы ввели что-то другое!");
        break;
}