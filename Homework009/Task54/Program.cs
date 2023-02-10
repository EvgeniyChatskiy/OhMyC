//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2



Console.Write("Enter \"length\" value: ");
byte length = ProtectFromIncorrectInput();
Console.Write("Enter \"heigh\" value: ");
byte heigh= ProtectFromIncorrectInput();

Console.WriteLine();
Console.Write("Original array now looks like this:\n");
short[,] array = CreateShortArray(length, heigh);
Console.WriteLine();
Console.Write("And this is the sorted array:\n");
SortingLinesOfArray(array, length, heigh);

byte ProtectFromIncorrectInput()
{
    byte number = 0;
    while (!Byte.TryParse(Console.ReadLine(), out number) || number <= 0) Console.Write("Incorrect input. Try again: ");
    return number;
} //BakaShield <3

short[,] CreateShortArray (byte length, byte heigh)
{
    short[,] array = new short[heigh, length];
    Random rnd = new Random();
    for (byte i = 0; i < array.GetLength(0); i++)
    {
        for (byte j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (short)rnd.Next(10, 100);
            Console.Write("{0, 3}", array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
} //Create new array and fill it with random positive numbers, then return the array

void SortingLinesOfArray(short[,] array, byte length, byte heigh)
{
    short temp = 0;
    for (byte i = 0; i < heigh; i++)
    {
        for (int j = 0; j < length; j++)
        {
            int k = j + 1;
            while (k < length)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
                k++;
            }
            Console.Write("{0, 3}", array[i, j]);
        }
    Console.WriteLine();
    }
} //Sort array, then print it
