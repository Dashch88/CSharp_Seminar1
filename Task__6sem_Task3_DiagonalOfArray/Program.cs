// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int[,] FillTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfDiag(int[,] array)
{
    int sumDiag = 0;
    int lengthDiag = 0;
    if (array.GetLength(0) >= array.GetLength(1)) lengthDiag = array.GetLength(1);
    else lengthDiag = array.GetLength(0);
    for (int i = 0; i < lengthDiag; i++)
    {
        sumDiag += array[i, i];
    }
    return sumDiag;
}

int[,] arr = new int[3, 3];

FillTwoDimArray(arr);
PrintArray(arr);

int sum = SumOfDiag(arr);
Console.WriteLine($"Сумма всех элементов по главной диагонале: {sum}");