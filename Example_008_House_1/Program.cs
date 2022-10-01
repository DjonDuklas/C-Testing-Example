Console.Clear();

int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int NumberOne = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int NumberTwo = int.Parse(Console.ReadLine()!);

if (NumberOne > NumberTwo)
{
    max = NumberOne;
    min = NumberTwo;
} 
if (NumberOne < NumberTwo)
{
    max = NumberTwo;
    min = NumberOne;
} 

Console.WriteLine($"Большим числом является {max} , а меньшим {min} ");