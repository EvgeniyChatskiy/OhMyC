//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
void PrintArray(int[,] arrayPrint)
{
for (int i = 0; i < arrayPrint.GetLength(0); i++)
{
for (int j = 0; j < arrayPrint.GetLength(1); j++)
{
Console.Write($"{arrayPrint[i, j]}, ");
}
Console.WriteLine();
}
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
int[,] array2D = new int[m, n];
Random random = new Random();
for (int i = 0; i < array2D.GetLength(0); i++)
{
for (int j = 0; j < array2D.GetLength(1); j++)
{
array2D[i, j] = random.Next(min, max + 1);
}
}
return array2D;
}

int[,] SwapArray2d(int[,] oldArray)
{
    int[,] newArray = new int[oldArray.GetLength(1), oldArray.GetLength(0)];
    for (int i = 0; i < oldArray.GetLength(1); i++)
    {
        for (int j = 0; j < oldArray.GetLength(0); j++)
        {
            //Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
            void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayPrint[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandome2DArray(int m, int n, int min, int max)
{
    int[,] array2D = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = random.Next(min, max + 1);
        }
    }
    return array2D;
}

int[,] SwapStringArray2d(int[,] oldArray)
{
    int temp = 0;
    for (int i = 0; i < oldArray.GetLength(1); i++)
    {
        temp = oldArray[oldArray.GetLength(0) - 1, i];
        oldArray[oldArray.GetLength(0) - 1, i] = oldArray[0, i];
        oldArray[0, i] = temp;
    }
    return oldArray;
}
            Решение в группах задач:
//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
int row = 10;
int[,] triangle = new int[row, row];
const int cellWidth = 5;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

FillTriangle();
PrintTriangle();