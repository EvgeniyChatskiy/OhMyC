//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int start = 1;
int N = InputGuard();
PrintNumber(N, start);
int InputGuard()
{
    int N = 0;
    while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
    {
        Console.Write("Incorrect input. Try again: ");
    }
    return N;
}
void PrintNumber(int N, int start)
{
    if (start == N)
    {
        Console.Write($"{start}");
    }
    else
    {
        PrintNumber(N, start + 1);
        Console.Write($", {start}");
    }
}