// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int FuncAkkerman(int n, int m)
{
    if (m < 0 | n < 0)
    {
        Console.WriteLine();
        Console.WriteLine($"Ошибка, M и N должны быть больше или равны 0, повторный ввод");
        Console.Write("Введите число M: ");
        int x = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число N: ");
        int y = int.Parse(Console.ReadLine()!);
        return FuncAkkerman(y, x);
    }
    else

    if (n == 0) return m + 1;
    if (m == 0) return FuncAkkerman(n - 1, 1);
    else return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
}

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Функция Аккермана равна: {FuncAkkerman(n, m)}");