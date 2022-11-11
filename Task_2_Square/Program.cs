// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет
Console.WriteLine("Введите первое число");
string str = Console.ReadLine();
int a = int.Parse(str);
Console.WriteLine("Введите второе число");
str = Console.ReadLine();
int b = int.Parse(str);
if (b * b == a)
{
    Console.WriteLine("Первое число является квадротом второго числа.");
}
else
{
    Console.WriteLine("Первое число НЕ является квадротом второго числа.");
}