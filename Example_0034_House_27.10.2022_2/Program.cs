// Задача 50. Напишите программу, которая на вход принимает 
// число и возвращает индексы элемента в двумерном массиве или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Console.WriteLine("Введите число на проверку");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if ( numbers[i, j] != n )
        {
            
        }
        else
        {
            Console.WriteLine($"Индекс числа {n} равен [{i}, {j}]");
        }
    }
}

PrintArray(numbers);