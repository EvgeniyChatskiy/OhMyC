Console.Write("Введите размер массива в пределах от 1 до 255: ");
byte n = GetNumberFromConsole();
string[] array = new string[n];
byte count = 0;

for (byte i = 0; i < array.Length; i++)
{
    Console.Write($"Задайте значения для {i + 1} элемента: ");
    array[i] = Console.ReadLine();
    if (array[i].Length < 4) count++;
}

string[] sortedArray = new string[count];
count = 0;
for (byte j = 0; j < array.Length; j++)
{
    if (array[j].Length < 4) sortedArray[count++] = array[j];
}

Console.WriteLine("Отсортированный масив: " + "[\"" + string.Join("\", \"", sortedArray) + "\"]");

byte GetNumberFromConsole()
{
    byte n = 0;
    while (!byte.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.WriteLine("Введите размер массива в пределах от 1 до 255");
    }
    return n;
}
