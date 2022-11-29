// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите суммы отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

Console.Clear();

int[] array = new int[10];
int sumOfPositive = 0;
int sumOfNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");
    if (array[i] > 0) sumOfPositive += array[i];
    if (array[i] < 0) sumOfNegative += array[i];    
}
Console.WriteLine();
Console.WriteLine($"Сумма всех положитлеьных числе массива: {sumOfPositive}");
Console.WriteLine($"Сумма всех отрицательных числе массива: {sumOfNegative}");