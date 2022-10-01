Console.Clear();

Console.Write("Введите первое число: ");
int NumberOne = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int NumberTwo = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int NumberThree = int.Parse(Console.ReadLine()!);

int max = NumberOne;

if(NumberTwo > max ) max = NumberTwo;
if(NumberThree > max) max = NumberThree;

Console.WriteLine($"Большим числом является {max}");