//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет

Console.WriteLine("Зададим двумерный массив и заполним его случайными числами.");
Console.Write("Введите количество строк: ");
int m = YameteSenpaiBaka();
Console.Write("Введите количество столбцов: ");
int n = YameteSenpaiBaka();
int[,] array = FillArray(m, n);

Console.Write("Введите строку: ");
int i = YameteSenpaiBaka();
Console.Write("Введите столбец: ");
int j = YameteSenpaiBaka();

int isInRange = 0;
isInRange = ArrayInnerAreaCheck(array, i, j);


FindNumber(array, isInRange);
PrintArray(array);
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
    int min = 10;
    int max = 100;
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

//Поиск числа в массиве по индексу//
void FindNumber(int[,] array, int isInRange)
{
    if (isInRange == -1)
        Console.WriteLine("Такого числа нет в массиве");
    else
        Console.WriteLine($"{array[i - 1, j - 1]}");
}

//Проверка выхода за пределы массива + защита от дурака//
int ArrayInnerAreaCheck(int[,] array, int i, int j)
{
    if (array.GetLength(0) < i || array.GetLength(1) < j)
    {
        isInRange = -1;
        return isInRange;
    }
    else
        return isInRange;
}
