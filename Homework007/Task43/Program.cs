//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2\n");
Console.Write("Зададим k1: ");
double k1 = bakaShield();
Console.Write("Зададим b1: ");
double b1 = bakaShield();
Console.Write("Зададим k2: ");
double k2 = bakaShield();
Console.Write("Зададим b2: ");
double b2 = bakaShield();

double x = (k1 - k2);
x = (b1 - b2) / (x * (-1));
double y = (k2 * x) + b2;

Console.Write($"Прямые пересекаются в следующих координатах: x = {x}, y = {y}");
//Functions

double bakaShield()
{
    double num = 0;
    while (!double.TryParse(Console.ReadLine(), out num))
        Console.Write("Ввод литералов и символов недопустим. Повторите попытку: ");
    return num;
}
