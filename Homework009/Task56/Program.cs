//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System.ComponentModel.DataAnnotations;

Console.Write("Enter \"width\" value: ");
byte length = ProtectFromIncorrectInput();
Console.Write("Enter \"heigh\" value: ");
byte heigh = ProtectFromIncorrectInput();

while (length == heigh)
{
    Console.Write("This is a square. heigh value again: ");
    heigh = ProtectFromIncorrectInput();
}

Console.WriteLine();
Console.Write("Array looks like this:\n");
ushort[,] array = CreateShortArray(length, heigh);
byte minimal = FindLineWithMinimalSumOfNumbers(array);
Console.Write("The line with the smallest sum of numbers is {0} line", minimal);


byte FindLineWithMinimalSumOfNumbers(ushort[,] array)
{
    byte minimal = 0;
    ushort sum = 0;
    for (byte i = 0; i < array.GetLength(0); i++)
    {
        minimal = i;
        for (byte j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minimal > sum) minimal = i;
    }
    return minimal;
} //Find the line with the smallest sum of numbers

byte ProtectFromIncorrectInput()
{
    byte number = 0;
    while (!Byte.TryParse(Console.ReadLine(), out number) || number <= 0) Console.Write("Incorrect input. Try again: ");
    return number;
} //BakaShield <3

ushort[,] CreateShortArray(byte length, byte heigh)
{
    ushort[,] array = new ushort[heigh, length];
    Random rnd = new Random();
    for (byte i = 0; i < array.GetLength(0); i++)
    {
        for (byte j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (ushort)rnd.Next(1, 10);
            Console.Write("{0, 3}", array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
} //Create new array and fill it with random positive numbers, then return the array