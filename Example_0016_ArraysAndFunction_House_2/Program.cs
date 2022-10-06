// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


if (number / 100 > 1)
    {
    string a3 = number.ToString();
    Console.WriteLine ($"Третья цифра числа {a3[2]}");
    }

else
    {
    Console.WriteLine ("Третьей цифры нет");
    }