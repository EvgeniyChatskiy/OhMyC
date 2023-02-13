//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30
Console.Write("Enter \"M\" value: ");
int M = InputGuard();
Console.Write("Enter \"N\" value: ");
int N = InputGuard();
while(N < M)
{
    Console.Write("Second value must be greater than first. Try again: ");
    N = InputGuard();
}
int result = 0;
PrintMtoNsum(M, N, result);

void PrintMtoNsum(int M, int N, int result)
{
    if (M < N)
    {
        result += M;
        PrintMtoNsum(M + 1, N, result);
    }
    else if (M == N)
    {
        result += M;
        Console.WriteLine(result);
    }
}
int InputGuard()
{
    int num = 0;
    while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
    {
        Console.Write("Incorrect input. Try again: ");
    }
    return num;
}

