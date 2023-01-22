//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для составления таблицы кубов");
int.TryParse(Console.ReadLine(), out int N);
Console.WriteLine("Введите верное число");
for (int i = 1; N + 1 > i; i++)
    Console.Write(Function(i) + " ");
   
double Function(int N)
{
    return (int)Math.Pow(N, 3);
}
