// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Enter data AX: ");
double AX = double.Parse(Console.ReadLine());

Console.Write("Enter data AY: ");
double AY = double.Parse(Console.ReadLine());

Console.Write("Enter data AZ: ");
double AZ = double.Parse(Console.ReadLine());



Console.Write("Enter data BX: ");
double BX = double.Parse(Console.ReadLine());

Console.Write("Enter data BY: ");
double BY = double.Parse(Console.ReadLine());

Console.Write("Enter data BZ: ");
double BZ = double.Parse(Console.ReadLine());


double Distanse_Result = Math.Sqrt(Math.Pow(BX-AX, 2) + Math.Pow(BY-AY, 2) + Math.Pow(BZ-AZ, 2));


Console.WriteLine($"Distanse between 3 points: {Distanse_Result}");