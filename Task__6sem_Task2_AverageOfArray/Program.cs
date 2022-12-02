// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33

Console.Clear();

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double AverageOfArray(int[] array)
{
    double average = 0;
    int countOfPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            average += array[i];
            countOfPositive++;
        }
    }
    average = average / countOfPositive;
    return average;
}

Console.WriteLine("Введите количество элементов в массиве: ");

int[] array = new int[int.Parse(Console.ReadLine())];
array = FillArray(array);
PrintArray(array);
double averageArray = Math.Round(AverageOfArray(array), 2);

Console.WriteLine($"Среднее арифметическое всех пололжительных элементов массива равно:  {averageArray}");