//string[,] table = new string[2, 5];
//table[1, 2] = "слово";

//for (int rows= 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }

//}




//void printArray(int[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            Console.Write($"{matr[i, j]} ");
//        }
//    Console.WriteLine();
//    }

//}

//void fillArray(int[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            matr[i,j] = new Random().Next(1, 10);
//        }
//    }
//}

//int[,] matrix = new int[3, 4];

//fillArray(matrix);
//printArray(matrix);

//using System.Net.NetworkInformation;

//void printImage[,](int[,] image)
//{
//    for (int i = 0; i < image.GetLength(0); i++)
//    {
//        for (int j = 0; j < image.GetLength(1); j++)
//        {
//            //Console.Write($"{i[i, j]} ");
//            if (image[i, j] == 0) Console.Write($" ");
//            else Console.Write($"+");        }
//        Console.WriteLine();
//    }

//}

//void fillImage(int row, int col)
//{
//    if (Pic[row, col] == 0)
//    {
//        pic[row, col] = 1;
//        fillImage(row-1, col);
//        fillImage(row, col-1);
//        fillImage(row+1, col);
//        fillImage(row, col+1);
//    }
//}

//fillImage(13, 13)
//int[,] image = new int[3, 4];

int factorial (int n)
{
    if (n == 1) return 1;
    else return n * factorial(n-1);
}
Console.WriteLine(factorial(5));


int fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else fibonacci(n - 1) + fibonacci(n - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(fibonacci(i));
}