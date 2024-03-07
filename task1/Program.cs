// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());


void ShowNaturalNumber(int M, int N)
{
    int mindigit;
    int maxdigit;
    if (M < N)
    {
        mindigit = M;
        maxdigit = N;
    }
    else
    {
        mindigit = N;
        maxdigit = M;
    }
    if(mindigit != maxdigit)
    {
        Console.Write(mindigit + ", ");
        ShowNaturalNumber(mindigit + 1, maxdigit);
        //Console.Write(mindigit + ", ");
    }
    else {
        Console.Write(maxdigit);
    }
}

ShowNaturalNumber(M, N);
// void Main()
// {
// Console.Write("Введи N: ");
// int N = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи M: ");
// int M = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"N={N}, M={M}");
// if (M>N)
// for (int i = N; i <= M; i++)
//     Console.Write($" {i}");
// else
//     for (int i = M; i <= N; i++)
//         Console.Write($" {i}");
// }


// Main();