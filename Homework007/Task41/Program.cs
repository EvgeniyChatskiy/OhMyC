//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223 -> 3

Console.Write("Зададим количество проверяемых чисел: ");
int length = bakaShield();
int[] array = fillArray(length);


int count = checkNegativeDigits(array, length);

Console.WriteLine($"Введён следующий массив чисел: [{String.Join(",", array)}]\n");
Console.Write("Положительных чисел в массиве: ");
Console.WriteLine(count);

//Functions

int bakaShield()
{
    while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        Console.Write("Ошибка ввода. Повторите попытку: ");
    return length;
}

int[] fillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        int num = 0;
        Console.Write($"Введите {i + 1} число:");
        while (!int.TryParse(Console.ReadLine(), out num))
            Console.Write("Ввод литералов и символов недопустим. Повторите попытку: ");
        array[i] = num;
    }
    return array;
}

int checkNegativeDigits(int[] array, int length)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}