// Задача 2. Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int PowNumAInB(int numA, int numB)
{
    if (numB == 0)
    {
        return 1;
    }
    numA *= PowNumAInB(numA, numB - 1);
    return numA;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int powAInB = PowNumAInB(A, B);
Console.WriteLine($"{A} в степени {B} равно: {powAInB}");