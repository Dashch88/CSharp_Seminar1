// Написать программу: программа получает число с консоли, возводит в квадрат и выводит на экран.

Console.WriteLine("Привет! Введите число, чтобы его возвести в квадрат.");
string str = Console.ReadLine(); // Текст из консоли получаем всегда в строковом типе
int number = int.Parse(str); // int.Parse -- переводит строку (string) в целочисленное число (int)
int square = number * number;

Console.WriteLine("Квадрат вашего числа равен: " + square);