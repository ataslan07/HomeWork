// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter the first number: ");
int a = int.Parse(Console.ReadLine());;

Console.Write("Enter the second number: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Enter the third number: ");
int c = int.Parse(Console.ReadLine());

int MAX = a;
if(a > MAX) MAX = a;
if(b > MAX) MAX = b;
if(c > MAX) MAX = c;

Console.Write("MAX = ");
Console.WriteLine(MAX);

