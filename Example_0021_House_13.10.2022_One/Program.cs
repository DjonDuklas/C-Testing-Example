// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void Nature (int A, int B)
{
    int result = 1;
    for(int n = 1; n <= B; n++)
    {
        result = result * A; 
    }
    Console.WriteLine(result);
}

Console.Clear();

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Nature(A, B);
