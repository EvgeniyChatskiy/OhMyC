/*// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число для сравнения: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
   Console.Write(num1 + " - большее из двух чисел, а " + num2 + " меньшее");
else
   Console.Write(num2 + " - большее из двух чисел, а " + num1 + " меньшее");


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число для сравнения: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число для сравнения: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int count = 0;
while (count <3){
    if (num2 > max)
       max = num2;
    else if (num3 > max)
       max = num3;
    count++;
}
Console.Write("Наибольшим из всех чисел является число " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write("Введите число для проверки на чётность: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
   Console.Write("Введённое число является чётным");
else 
   Console.Write("Введённое число является нечётным");
   

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
    if (N < 0)
        Console.Write("Вы ввели число с отрицательным значением");
for (int i = 2; i <= N; i = i + 2)
     Console.Write(i + ", ");*/

Console.Write("Введите первое число для сравнения: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Наибольшее число равно " + (Math.Max(x, y))); 
Console.WriteLine("Наименьшее число равно " + (Math.Min(x, y))); 