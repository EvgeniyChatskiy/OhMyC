//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Calculate(int num)
{
    int result = 0;
    for (int i = num; i > 0; i = i / 10)
    {
        int temp = i % 10;
        result += temp;
    }
    return result;
}

Console.Write("Задайте число для вывода суммы всех его чисел: ");
if (!Int32.TryParse(Console.ReadLine(), out int num))
{
    Console.WriteLine("Ввод неверный");
    return;
}

if (num < 0)
{
    Console.WriteLine("Введите положительное число больше 0");
    return;
}

int result = Calculate(num);
Console.WriteLine(result);
