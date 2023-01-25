//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

int Multiplier(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; result = result * num1) i++;
    return result;
}
int result = 0;
Console.WriteLine("Возводим числа в натуральную степень.");
Console.Write("Введите возводимое число: ");
if (!Int32.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine("Ввод не верный");
    return;
}
Console.Write("Введите степень: ");
if (!Int32.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine("Ввод не верный");
    return;
}
if (num2 <= 0)
{
    Console.WriteLine("Введите положительное число больше 0");
    return;
}
result = Multiplier(num1, num2);
Console.WriteLine(result);
