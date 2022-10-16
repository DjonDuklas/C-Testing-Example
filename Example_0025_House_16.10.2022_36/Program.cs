// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandomArr(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

int sum = 0;

for (int i = 0; i < qwer.Length; i+=2)
{
    sum = sum + qwer[i];
}

Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях равно : {sum}");
