// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите целое число:");
string str = Console.ReadLine();
Console.WriteLine();
int number = int.Parse(str);
int negativeNumber = number * -1;
while (negativeNumber <= number)
{
    Console.WriteLine(negativeNumber);
    negativeNumber++;
}
