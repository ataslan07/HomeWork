// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет

Console.Clear();
Console.Write("enter the three-digit number: ");
int num = int.Parse(Console.ReadLine());
int result = 0;

if (num<100)
{
    Console.WriteLine("третьей цифры в числе нет");
    return;
}
else
{
    while(num >= 100)
    {
        num = num / 10;
    }
    result = num % 10;
}
Console.WriteLine(result);


