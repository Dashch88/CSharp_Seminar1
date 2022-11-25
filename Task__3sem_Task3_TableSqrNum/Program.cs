// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.Clear();

Console.WriteLine("Введите N. Целое, положительное.");
int num = int.Parse(Console.ReadLine());
double sqr = 1;

Console.WriteLine();

if (num < 1)
{
    Console.WriteLine("Вы ввели число не удовлетворяющее условиям.");
}
else
{
    for (int i = 1; i < num + 1; i++)
    {
        sqr = Math.Pow(i, 2);
        Console.Write(sqr + " ");
    }
}
Console.WriteLine();