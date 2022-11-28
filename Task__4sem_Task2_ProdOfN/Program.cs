// Задача 2:
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

int ProdOfN(int n)
{
    int prod = 1;
    for (int i = 2; i < n + 1; i++)
    {
        prod = prod * i;
    }
    return prod;
}

Console.Clear();
Console.WriteLine("Введите число N для которого нужно найти произвдение чисел от 1 до N.");

int num = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Произведение чисел от 1 до введённого N: " + ProdOfN(num));