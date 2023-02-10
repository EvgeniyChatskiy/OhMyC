//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

byte[,] array = new byte[4, 4];
CreateArray(array);
PrintArray(array);

void PrintArray(byte[,] array)
{
    for (byte i = 0; i < 4; i++)
    {
        for (byte j = 0; j < 4; j++)
        {
            Console.Write("{0, 3}", $"{array[i, j]:D2}");
        }
        Console.WriteLine();
    }
} // Print array

byte[,] CreateArray(byte[,] array)
{
    byte i = 0;
    byte j = 0;
    byte number = 0;

    while (j <= 3) 
    {
        array[i, j] = ++number;
        if (j < 3) j++;
        else break;
    }// up to 4
    i++;
    while (i <= 3) 
    {
        array[i, j] = ++number;
        if (i < 3) i++;
        else break;
    }// up to 7
    j--;
    while (j >= 0) 
    {
        array[i, j] = ++number;
        if (j > 0) j--;
        else break;
    }// up to 10
    i--;
    while (i >= 1) 
    {
        array[i, j] = ++number;
        if (i > 1) i--;
        else break;
    }// up to 12
    j++;
    while (j <= 2)
    {
        array[i, j] = ++number;
        if (j < 2) j++;
        else break;
    }
    array[2, 2] = ++number;
    array[2, 1] = ++number;
    return array;

    //byte[,] array = new byte[4, 4];
    //for (byte i = 0; i < array.GetLength(0); i++)
    //{
    //    for (byte j = 0; j < array.GetLength(1); j++)
    //    {
    //array[i, j] = ++number;
    //Console.Write("{0, 3}", array[i, j]);
    //    }
    //    Console.WriteLine();
    //}
} // Create new array and fill it with random positive numbers, then return the array