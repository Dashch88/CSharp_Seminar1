// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Clear();

int[,] FillDimArray(int rows, int columns)
{
    int[,] arrayA = new int[rows, columns];

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            arrayA[i, j] = new Random().Next(0, 9);
        }
    }
    return arrayA;
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

int[,] SqrEvenIndexElements(int[,] arrayB)
{
    for (int i = 0; i < arrayB.GetLength(0); i += 2)
    {
        for (int j = 0; j < arrayB.GetLength(1); j += 2)
        {
            arrayB[i, j] *= arrayB[i, j];
        }
    }
    return arrayB;
}

Console.Write("Введите количество строк в массиве: ");
int numOfRows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int numOfColumns = int.Parse(Console.ReadLine());

int[,] arrayA = FillDimArray(numOfRows, numOfColumns);
PrintDimArray(arrayA);

SqrEvenIndexElements(arrayA);
Console.WriteLine();
PrintDimArray(arrayA);