// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void RandomArr(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
} 

void PrintArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

Console.Clear();

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

double[] qwer = new double[size];

RandomArr(qwer);
PrintArray(qwer);

double min = qwer[0];
double max = qwer[0];

for (int i = 0; i < qwer.Length; i++)
{
    if (qwer[i] > max)
        {
            max = qwer[i];
        }
    if (qwer[i] < min)
        {
            min = qwer[i];
        }
}

Console.WriteLine($" Разница между максимальным и минимальным значением = {max - min}");