//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
int N = InputGuard();
PrintNumber(N);
int InputGuard()
{
    int N = 0;
    while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
    {
        Console.Write("Incorrect input. Try again: ");
    }
    return N;
}
void PrintNumber(int N)
{
    if (N <= 0)
    {
        return;
    }
    else if (N == 1)
    {
        Console.Write($"{N}");
    }
    else
    {
        PrintNumber(N - 1);
        Console.Write($", {N}");
    }
}


//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5-> "1, 2, 3, 4, 5"
//M = 4; N = 8-> "4, 6, 7, 8
//int GetNumber()
//{
//    int N = 0;
//    while (!int.TryParse(Console.ReadLine(), out N))
//    {
//        Console.Write("Incorrect input. Try again: ");
//    }
//    return N;
//}
//void PrintNumber(int M, int N)
//{
//    if (M > N)
//    {
//        PrintNumber(M - 1, N);
//        Console.Write($", {M}");
//    }
//    else if (M < N)
//    {
//        PrintNumber(M, N - 1);
//        Console.Write($", {N}");
//    }
//    else if (M == N)
//    {
//        Console.Write($"{M}");
//    }
//}
//int M = GetNumber();
//int N = GetNumber();
//PrintNumber(M, N);
//Console.ReadKey();

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5-> 243(3⁵)
//A = 2; B = 3-> 8
//double PowNumbers(double numA, double numB)
//{
//    if (numB == 1)
//    {
//        return numA;
//    }
//    else if (numB == 0)
//    {
//        return 1;
//    }
//    else if (numB < 0)
//    {
//        return 1 / PowNumbers(numA, Math.Abs(numB));
//    }
//    else
//    {
//        return numA * PowNumbers(numA, numB - 1);
//    }
//}

//double GetNumber()
//{
//    Console.Write($"Введите значение числа: ");
//    double.TryParse(Console.ReadLine(), out double result);
//    return result;
//}

//double numberA = GetNumber();
//double numberB = GetNumber();
//Console.WriteLine($"Число {numberA} в степени {numberB} = {PowNumbers(numberA, numberB)}");