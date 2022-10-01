Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1;

while(count <= number)
{
    if (count % 2 == 0)
        {
        Console.Write($"{count}, ");
        }

    count = count + 1;

}
Console.Write("\n");
Console.WriteLine("Показали все чётные числа от 1 до Введенного числа");