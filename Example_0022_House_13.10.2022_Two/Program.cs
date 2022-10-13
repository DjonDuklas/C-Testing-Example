// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        int i = number % 10;
        number = number / 10;
        sum = sum + i;
    }
    return sum;
}


Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSum(number));