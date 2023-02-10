//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Write("Enter \"length\" value: ");
byte length = ProtectFromIncorrectInput();
Console.Write("Enter \"heigh\" value: ");
byte heigh = ProtectFromIncorrectInput();

Console.WriteLine();
Console.Write("Printing first array:\n");
short[,] array1 = CreateShortArray(length, heigh);

Console.WriteLine();
Console.Write("Printing second array:\n");
short[,] array2 = CreateShortArray(length, heigh);

Console.WriteLine();
Console.Write("First array * second array:\n");
ArrayProduct(array1, array2, length, heigh);

void ArrayProduct(short[,] array1, short[,] array2, byte length, byte heigh)
{
    int[,] arrayResult = new int[heigh, length];
    for (byte i = 0; i < heigh; i++)
    {
        for (byte j = 0; j < length; j++)
        {
            arrayResult[i, j] = array1[i, j] * array2[i, j]; 
            Console.Write("{0, 3}", $"{arrayResult[i, j]:D2}");
        }
    Console.WriteLine();   
    }
} //Find product of two generated array, then print result as new array

byte ProtectFromIncorrectInput()
{
    byte number = 0;
    while (!Byte.TryParse(Console.ReadLine(), out number) || number <= 0) Console.Write("Incorrect input. Try again: ");
    return number;
} //BakaShield <3

short[,] CreateShortArray(byte length, byte heigh)
{
    short[,] array = new short[heigh, length];
    Random rnd = new Random();
    for (byte i = 0; i < heigh; i++)
    {
        for (byte j = 0; j < length; j++)
        {
            array[i, j] = (short)rnd.Next(1, 10);
            Console.Write("{0, 3}", array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
} //Create new array and fill it with random positive numbers, then return the array