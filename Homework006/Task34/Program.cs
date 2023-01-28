//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Write("Введите размер массива: ");
int num = bakaShield();
int[] array = arrayGenerate(num, 100, 1000);
printArray(array);
int count = evenArrayNum(array);

Console.Write($"Количество чётных чисел в массиве: {count}");
Console.ReadKey();

//Functions//

void printArray(int[] array)
{
    System.Console.WriteLine($"[{String.Join(",", array)}]\n");
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

int[] arrayGenerate(int num, int min, int max)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; array[i++] = rnd.Next(min, max));
    return array;
}

int evenArrayNum(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}