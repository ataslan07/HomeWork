// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("enter the three-digit number: ");
int num = int.Parse(Console.ReadLine());
if (num>99 && num <1000)
{
    int a1 = num/10;
    int a2 = a1%10;
        Console.Write($"{a2}");
}

else
{
    Console.Write("the entered number is not a three-digit number");
}