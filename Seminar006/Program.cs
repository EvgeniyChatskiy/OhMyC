    // Задача 39: Напишите программу, которая перевернёт одномерный массив
    // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
    // [1 2 3 4 5] -> [5 4 3 2 1]
    // [6 7 3 6] -> [6 3 7 6]

//void PrintArray(int[] array)
//{
//    System.Console.Write($"[{String.Join(",", array)}]\n");
//}

//int[] GenerateArr(int n, int min, int max)
//{
//    int[] arrNum = new int[n];

//    Random rnd = new Random();

//    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

//    return arrNum;
//}

//int[] RevertArray(int[] array)
//{
//    int[] result = new int[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {
//        result[array.Length - i - 1] = array[i];
//    }

//    return result;
//}


//int[] array = GenerateArr(12, -9, 9);
//Console.WriteLine("Сгенерированный массив");
//PrintArray(array);

//int[] result = RevertArray(array);
//Console.WriteLine("Перевёрнутый массив");
//PrintArray(result);

    //Решение в группах задач:
    //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
    //Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите длину стороны AC: ");
int AC = bakaShield();
Console.Write("Введите длину стороны AB: ");
int AB = bakaShield();
Console.Write("Введите длину стороны BC: ");
int BC = bakaShield();

System.Console.Write($"Данный треугольник {(checkTriangle(AC, AB, BC) ? "" : "не ")}может существовать");

bool checkTriangle(int AC, int AB, int BC)
{
    if ((AC < AB + BC) && (AB <  AC + BC) && (BC < AB + AC))
    {
        return true;
    }
    return false;
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

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

System.Console.Write("Введите десятичное число: ");
int num = getVar();
int tmpNum = num;
int count = 0;

while (tmpNum > 0)
{
    count++;
    tmpNum /= 2;
}

tmpNum = num;
int[] arrNum = new int[count];
for (int i = arrNum.Length; i > 0; i--)
{
    arrNum[i - 1] = tmpNum % 2;
    tmpNum /= 2;
}

printArr(num, arrNum);

// --- FUNCs --- //
int getVar()
{
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric)
    {
        Console.Write($"Введите проверяемое число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);

        if (varValue < 0)
        {
            isNumeric = false;
        }
    }

    return varValue;
}

void printArr(int num, int[] nums)
{
    System.Console.Write($"{num} -> {String.Join("", nums)}\n");
}


//Решение в группах задач:
//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5-> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] inpArr)
{
    int[] result = new int[inpArr.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inpArr[i];
    }
    return result;
}

int[] GenerateArray(int array_Size)
{
    int[] result = new int[array_Size];
    Random tmp = new Random();
    for (int i = 0; i < array_Size; i++)
    {
        result[i] = tmp.Next(100, 1000);
    }

    return result;
}

void printArr(int[] nums)
{
    System.Console.Write($"{String.Join(" ", nums)}\n");
}

System.Console.WriteLine("Введите размер массива");
int input = 0;
int.TryParse(Console.ReadLine(), out input);
int[] arr1 = GenerateArray(input);
System.Console.WriteLine("Исходный массив");
printArr(arr1);
int[] copy = CopyArray(arr1);
System.Console.WriteLine("Копия массива");
printArr(copy);