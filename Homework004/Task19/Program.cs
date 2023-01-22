﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
//(НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ.Используем операторы % и /).
//14212->нет
//12821->да
//23432->да

void WriteText(string msg)
{
    Console.Write(msg);
}
WriteText(msg: "Введите целое пятизначное число: ");
if (int.TryParse(Console.ReadLine(), out int num))
{

    //int num = Convert.ToInt32(Console.ReadLine());
    if (num < 10000 || num > 99999)
    {
        WriteText("Вы ввели неверное число");
        return;
    }
    if ((num / 10000) == (num % 10))
        if ((num / 1000) % 10 == (num % 100) / 10)
            WriteText("Число является палиндромом");
        else
            WriteText("Число не является палиндромом");
    else
        WriteText("Число не является палиндромом");
}  
else
    WriteText("Вы ввели не числовые знаки");
    return;