Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
    {
    Console.Write("Введенное число является четным");
    Console.Read();
    }
else
    {
    Console.Write("Введенное число нечетное");
    Console.Read();
    }