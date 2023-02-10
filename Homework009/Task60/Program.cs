//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

Console.Write("Enter \"X\" value: ");
byte length = ProtectFromIncorrectInput();
Console.Write("Enter \"Y\" value: ");
byte heigh = ProtectFromIncorrectInput();
Console.Write("Enter \"Z\" value: ");
byte depth = ProtectFromIncorrectInput();
if ((length * heigh) * depth + 11 > 99) Console.WriteLine("The array is overflowing");
else CreateArray(length, heigh, depth);

void CreateArray(byte length, byte heigh, byte depth)
{
    byte number = 9;
    uint[,,] array = new uint[heigh, length, depth];
    Random rnd = new Random();
    for (byte z = 0; z < array.GetLength(2); z++)
    {
        for (byte i = 0; i < array.GetLength(0); i++)
        {
            for (byte j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, z] = ++number;
                //if (array)
                Console.WriteLine($"[{i}, {j}, {z}] : {array[i, j, z]}");
            }
        }
    }
} //Create new array and fill it with random positive numbers, then return the array

byte ProtectFromIncorrectInput()
{
    byte number = 0;
    while (!Byte.TryParse(Console.ReadLine(), out number) || number <= 0) Console.Write("Incorrect input. Try again: ");
    return number;
} //BakaShield <3

