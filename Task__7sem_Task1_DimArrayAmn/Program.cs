// Задача 1: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int[,] FillDimArrayAmn(int rows, int columns)
{   
    int[,] arrayAmn = new int[rows, columns];

    for (int i = 0; i < arrayAmn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayAmn.GetLength(1); j++)
        {
            arrayAmn[i, j] = i + j;
        }
    }
    return arrayAmn;
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

Console.Write("Введите количество строк в массиве: ");
int numOfRows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int numOfColumns = int.Parse(Console.ReadLine());

int[,] arrayA = FillDimArrayAmn(numOfRows, numOfColumns);
PrintDimArray(arrayA);