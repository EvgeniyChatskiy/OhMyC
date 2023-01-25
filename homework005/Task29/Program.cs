//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

int[] array = new int[8];
Console.WriteLine("Зададим массив из 8 элементов и выведем его на экран");
Console.Write("Введите 1 число: ");
array[0] = EnterNumbers();
Console.Write("Введите 2 число: ");
array[1] = EnterNumbers();
Console.Write("Введите 3 число: ");
array [2] = EnterNumbers();
Console.Write("Введите 4 число: ");
array[3] = EnterNumbers();
Console.Write("Введите 5 число: ");
array[4] = EnterNumbers();
Console.Write("Введите 6 число: ");
array[5] = EnterNumbers();
Console.Write("Введите 7 число: ");
array[6] = EnterNumbers();
Console.Write("Введите 8 число: ");
array[7] = EnterNumbers();

int EnterNumbers()
{
    //int num = Convert.ToInt32(Console.ReadLine());
    if (!int.TryParse(Console.ReadLine(), out int num))
    {
        Console.WriteLine("Неверный ввод");
        return EnterNumbers();
    }
    return num;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        Console.Write(",");
    }
}