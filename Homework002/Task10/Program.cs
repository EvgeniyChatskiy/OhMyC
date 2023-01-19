Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int length = 0;
while (num2 > 0)
{
    length++;
    num2 /= 10;
}
if (length > 3 || length < 3)
{
    Console.WriteLine("Вы ввели неверное число");
    return;
}
int num1 = num % 100;
int middleDigit = num1 / 10;
Console.Write("Вторая цифра числа = " + middleDigit);