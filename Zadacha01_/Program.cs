//  Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

int FuncIntegers(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine($"Ошибка, M должно быть меньше или равно N, повторный ввод");
        Console.Write("введите число M: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите число N: ");
        int y = Convert.ToInt32(Console.ReadLine());
        return FuncIntegers(x, y);
    }
    else
    {
        if (n == m)
        {
            Console.Write($"{n}");
            return n;
        }

        else
        {
            Console.Write($"{m}, ");
            return FuncIntegers(m + 1, n);
        }
    }
}

Console.Write("Введите число M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int y = Convert.ToInt32(Console.ReadLine());
FuncIntegers(x, y);
