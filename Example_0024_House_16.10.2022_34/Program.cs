// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 586, 234] -> 2


void RandomArr(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
} 

void PrintArray(int[] mass)
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

int[] qwer = new int[size];

RandomArr(qwer);
PrintArray(qwer);

int result = 0;

for (int i = 0; i < qwer.Length; i++)
{
    if (qwer[i] % 2 == 0)
    {
        result++;
    }
}

Console.WriteLine($" В массиве {result} четных числа");
