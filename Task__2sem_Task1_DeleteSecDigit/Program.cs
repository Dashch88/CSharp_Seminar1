// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное число: " + number);
int first = number / 100;
int three = number % 10;
Console.WriteLine("Без второй цифры получается такое: " + first + three);