// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int a2 = number / 10;
a2 = a2 % 10;

Console.WriteLine ($"Вторая цифра числа {a2}");