// // Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, 
// // на пересечении которых расположен наименьший элемент.

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

int[] FindingMinElement(int[,] arrayForSearch)
{
    int min = arrayForSearch[0, 0];
    int[] arrayMin = { 0, 0 };
    for (int i = 0; i < arrayForSearch.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForSearch.GetLength(1); j++)
        {
            if (min > arrayForSearch[i, j])
            {
                min = arrayForSearch[i, j];
                arrayMin[0] = i;
                arrayMin[1] = j;
            }
        }
    }
    return arrayMin;
}

int[,] DeleteArrayRowColumn(int[,] arrayMinElement, int[] arrayMinIndex)
{
    int[,] arrayDeleteRowColumn = new int[arrayMinElement.GetLength(0) - 1, arrayMinElement.GetLength(1) - 1];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < arrayMinElement.GetLength(0); i++)
    {
        if (arrayMinIndex[0] != i)
        {
            for (int j = 0; j < arrayMinElement.GetLength(1); j++)
            {
                if (arrayMinIndex[1] != j)
                {
                    arrayDeleteRowColumn[indexRow, indexColumn] = arrayMinElement[i, j];
                    indexColumn++;
                }
            }
            indexColumn = 0;
            indexRow++;
        }
    }
    return arrayDeleteRowColumn;
}

Console.Write("Введите количество строк в массиве: ");
int numOfRows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int numOfColumns = int.Parse(Console.ReadLine());

int[,] arrayA = FillDimArray(numOfRows, numOfColumns);
PrintDimArray(arrayA);
Console.WriteLine();
int[] arrMin = FindingMinElement(arrayA);
Console.WriteLine($"Минимальный элемент: {arrayA[arrMin[0], arrMin[1]]} с индексами [{arrMin[0]}, {arrMin[1]}]");
Console.WriteLine();
int[,] arrDel = DeleteArrayRowColumn(arrayA, arrMin);
PrintDimArray(arrDel);