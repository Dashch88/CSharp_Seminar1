// Задача 1. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

int PrintAllNumbers(int n, int maxN)
{
    if (n == 0)
    {
        return 0;
    }
    Console.Write($"{maxN - (n - 1)} ");
    PrintAllNumbers(n - 1, maxN);
    return n;
}

Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine());
PrintAllNumbers(numN, numN);
Console.WriteLine();