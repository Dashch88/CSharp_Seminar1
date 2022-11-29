// Задача 2: Задайте массив из 10 элементов и положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    Console.Write($"{array[i]} ");
}

Console.WriteLine();