﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Clear();
Console.Write("Enter the number: ");
double a = double.Parse(Console.ReadLine());
double even = (a*a)/2;
if (even % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

