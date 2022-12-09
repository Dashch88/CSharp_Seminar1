// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

Console.Clear();

int[,] FillDimArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void PrintDimArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayForPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeFirstLastRows(int[,] arrayForChange)
{
    for (int j = 0; j < arrayForChange.GetLength(1); j++)
    {
        int temp = arrayForChange[0, j];
        arrayForChange[0, j] = arrayForChange[arrayForChange.GetLength(0) - 1, j];
        arrayForChange[arrayForChange.GetLength(0) - 1, j] = temp;
    }
    return arrayForChange;
}

Console.Write("Введите количество строк в массиве: ");
int numOfRows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int numOfColumns = int.Parse(Console.ReadLine());

int[,] arrayA = FillDimArray(numOfRows, numOfColumns);
PrintDimArray(arrayA);
Console.WriteLine();
ChangeFirstLastRows(arrayA);
PrintDimArray(arrayA);