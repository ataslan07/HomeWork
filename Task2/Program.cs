﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



Console.Clear();
Console.Write("Enter the first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write("Max = " + a);
}
else
{
    Console.Write("Max = " + b);
}
