Console.WriteLine("Введите число дня недели");
if(int.TryParse(Console.ReadLine(), out int numDay));
else
{
Console.Write("Ввод неверный. Пожалуйста, введите корректное число");
return;
}
if (numDay < 0)
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
    return;
}   
switch (numDay)
{
    case 6:
        Console.Write("Выходной");
        break;
    case 7:
        Console.Write("Выходной");
        break;
    
    default:
        Console.Write("Рабочий");
        break;
}
