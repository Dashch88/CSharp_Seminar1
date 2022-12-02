// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// // [6 7 3 6] -> [6 3 7 6]

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

int[] ReverseArray(int[] array)
{
    int box;
    for (int i = 0; i < (array.Length / 2); i++)
    {
        box = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = box;
    }
    return array;
}

Console.WriteLine("Введите количество элементов в массиве: ");

int[] array = new int[int.Parse(Console.ReadLine())];
array = FillArray(array);
PrintArray(array);

ReverseArray(array);
PrintArray(array);