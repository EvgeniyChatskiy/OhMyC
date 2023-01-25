//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

int[] array = new int[8];
Console.WriteLine("Зададим массив из 8 элементов и выведем его на экран");

array[0] = EnterNumbers();
array[1] = EnterNumbers();
array[2] = EnterNumbers();
array[3] = EnterNumbers();
array[4] = EnterNumbers();
array[5] = EnterNumbers();
array[6] = EnterNumbers();
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