﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string num = Console.ReadLine();
int array = num.Length;

if (array == 5)
{
 if (num[0] == num[4] && num[1] == num[3])
    {
 Console.WriteLine($"{num} - является палиндромом");
    }
 else
    {
 Console.WriteLine($"{num} - не является палиндромом");
    }
}
else
{
 Console.WriteLine($"ОШИБКА: {num} - не является пятизначным числом");
}