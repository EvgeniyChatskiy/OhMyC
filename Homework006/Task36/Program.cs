//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

Console.Write("Введите размер массива: ");
int num = bakaShield();
int[] array = fillRandomArray(num, -99, 100);
int sum = sumOddNum(array);

printArray(array);
Console.Write($"Cумма элементов, стоящих на нечётных позициях: {sum}");
Console.ReadKey();

//Functions//

int[] fillRandomArray(int num, int min, int max)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; array[i++] = rnd.Next(min, max));
    return array;
}


int bakaShield()
{
    if (!int.TryParse(Console.ReadLine(), out int num))
    {
        Console.Write("Ввод литералов и символов недопустим. Повторите попытку: ");
        return bakaShield();
    }
    else if (num <= 0)
    {
        Console.Write("Введено отрицательное или нулевое числовое значение. Повторите попытку: ");
        return bakaShield();
    }
    else
        return num;
}

    int sumOddNum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}

void printArray(int[] array)
{
    System.Console.WriteLine($"[{String.Join(",", array)}]\n");
}