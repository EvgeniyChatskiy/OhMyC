//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Зададим двумерный массив из целых чисел и найдём среднее арифметическое в каждом столбце.");
Console.Write("Введите количество строк: ");
int m = YameteSenpaiBaka();
Console.Write("Введите количество столбцов: ");
int n = YameteSenpaiBaka();

int[,] array = FillArray(m, n);
float average = 0;


PrintArray(array);
AverageNumber(array, average);
Console.ReadKey();

//Защита от дурака//
int YameteSenpaiBaka()
{
    int input = 0;
    while (!int.TryParse(Console.ReadLine(), out input) || input <= 0) Console.Write("Ошибка ввода. Повторите попытку: ");
    return input;
}

//Заполнение массива случайными числами//
int[,] FillArray(int m, int n)
{
    int min = 1;
    int max = 10;
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

//НАхождение среднего арифметического каждого столбца//
void AverageNumber(int[,] array, float average)
{
    Console.Write("\nСреднее арифметическое каждого столбца: \n");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average /= array.GetLength(0);
        Console.Write($"{Math.Round(average, 1)}" + "  ");
    }
   
}

//Печать массива//
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

