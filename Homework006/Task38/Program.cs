//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int length = bakaShield();
float[] array = arrayFill(length, -100, 1000);
float diff = diffMaxMin(array);

printArray(array);
Console.Write($"Разница между максимальным и минимальным элементов массива: {diff}");
Console.ReadKey();


//Functions//

float[] arrayFill(int length, float min, float max)
{
    float[] array = new float[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; array[i++] = rnd.Next((int)min, (int)max));
    return array;
}

int bakaShield()
{
    if (!float.TryParse(Console.ReadLine(), out float length))
    {
        Console.Write("Ввод литералов и символов недопустим. Повторите попытку: ");
        return bakaShield();
    }
    else if (length <= 0)
    {
        Console.Write("Введено отрицательное или нулевое числовое значение. Повторите попытку: ");
        return bakaShield();
    }
    else
        return (int)length;
}

void printArray(float[] array)
{
    System.Console.WriteLine($"[{String.Join(",", array)}]\n");
}

float diffMaxMin(float[] array)
{
    float min = array.Min();
    float max = array.Max();
    float diff = max - min;
    return diff;
}