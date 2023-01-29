//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53

using System.Diagnostics.CodeAnalysis;

double method()
{
    if (double.TryParse(Console.ReadLine(), out double num))
        return num;
    else
        Console.Write("Поддерживается ввод только числовых символов. Повторите ввод данных: ");
    return method();
}
double x1 = 0; //double x1 = method();
double y1 = 0; //double y1 = method();
double z1 = 0; //double z1 = method();
double x2 = 0; //double x2 = method();
double y2 = 0; //double y2 = method();
double z2 = 0; //double z2 = method();
double distance;
Console.Write("Введите значение для координаты x1: ");
x1 = method();
Console.Write("Введите значение для координаты y1: ");
y1 = method();
Console.Write("Введите значение для координаты z1: ");
z1 = method();
Console.Write("Введите значение для координаты x2: ");
x2 = method();
Console.Write("Введите значение для координаты y2: ");
y2 = method();
Console.Write("Введите значение для координаты z2: ");
z2 = method();
Console.WriteLine($"Были введены следующие координаты: x1={x1}, y1={y1}, z1={z1}, x2={x2}, y2={y2}, z2={z2}");
distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
Console.Write("Расстояние между точками: " + distance.ToString("0.##"));