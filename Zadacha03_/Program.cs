// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] CreateArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCycleArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayRecursion(int[] array, int size)
{
    if (size <= 0) return;
    if (size == 1) Console.Write(array[size - 1]);
    else  
    {
        Console.Write($"{array[size - 1]} ");
        PrintArrayRecursion(array, size - 1);
    }
}

Console.Write("Enter array size: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Enter array min: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Enter array max: ");
int max = int.Parse(Console.ReadLine()!);

int[] arr = CreateArray(min, max, size);
Console.WriteLine();
Console.WriteLine($"Исходный массив циклом: ");
PrintCycleArray(arr);
Console.WriteLine($"Полученный массив массив рекурсией: ");
PrintArrayRecursion(arr, size);
