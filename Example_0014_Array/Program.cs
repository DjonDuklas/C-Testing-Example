// int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

// int n = array.Length;
// int find = 8;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//     }
//     // index = index + 1;
//     index++;
// }

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);