//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Зададим двумерный массив и заполним его случайными вещественными числами.");
Console.Write("Введите длину массива:");
int n = yameteSenpaiBaka();
Console.Write("Введите высоту массива:");
int m = yameteSenpaiBaka();
Console.Write("Введите порог минимального числа: ");
int min = checkMinimalNumber();
Console.Write("Введите порог максимального числа: ");
int max = checkMinimalNumber();

while (min >= max)
{
    Console.WriteLine("Минимальное значение случайного числа не может быть больше значения максимального. Повторите ввод минимального числа: ");
    min = checkMinimalNumber();
}

double[,] array = fillArray(m, n, min, max);
printArray(array);



//Защита от дурака//
int yameteSenpaiBaka()
{
    int input = 0;
    while (!int.TryParse(Console.ReadLine(), out input) || input <= 0) Console.Write("Ошибка ввода. Повторите попытку: ");
    return input;
}

//Проверка минимального числа на корректность//
int checkMinimalNumber()
{
    int input = 0;
    while (!int.TryParse(Console.ReadLine(), out input)) Console.Write("Ошибка ввода. Повторите попытку: ");
    return input;
}

//Заполнение массива случайными числами//
double[,] fillArray(int m, int n, int min, int max)
{
    Random rnd = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double temp1 = rnd.NextDouble();
            double temp2 = rnd.Next(min, max);
            array[i, j] = Math.Round(temp1 * temp2, 1); 
        }
    }
    return array;
}

//Печать массива//
void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
