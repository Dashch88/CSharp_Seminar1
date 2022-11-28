// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumOfN(int n)
{
    int sum = 1;
    for (int i = 2; i < n + 1; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число N для которого нужно найти сумму чисел от 1 до N.");

int num = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Сумма чисел от 1 до введённого N: " + SumOfN(num));