Console.Write("Введите любое число: ");
if(int.TryParse(Console.ReadLine(), out int num));
else
{
Console.Write("Ввод неверный. Пожалуйста, введите корректное число");
return;
}
if (num < 0)
   num = Math.Abs(num);
int num2 = num;
int length = 0;
while (num2 > 0)
{
    length++;
    num2 /= 10;
}
while (length > 3)
{ 
    num = num / 10;
    length--;
}
if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
else 
    num = num % 10;
    
Console.Write("Третья цифра из заданного числа: " + num);