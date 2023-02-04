//Console.WriteLine("Введите массив целых чисел через пробел:");
//string input = Console.ReadLine()!;
//string[] numberStrings = input.Split(" ");
//int[] numbers = new int[numberStrings.Length];

//for (int i = 0; i < numbers.Length; i++)
//    numbers[i] = int.Parse(numberStrings[i]);

//PrintArray(numbers);



//int[,] GenerateArray(int m, int n, int min, int max)
//{
//    int[,] array = new int[m, n];

//    Random random = new Random();

//    for (int i = 0; i < array.GetLength(0); i++)
//        for (int j = 0; j < array.GetLength(1); j++)
//            array[i, j] = random.Next(min, max + 1);

//    return array;
//}

//void PrintArray2D(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//            Console.Write(array[i, j] + ", ");
//        Console.WriteLine();
//    }
//}

//var array = GenerateArray(4, 3, 0, 9);
//PrintArray2D(array);

//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
//выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

//float randNum = rnd.NextSingle() * (max - min) + min;

