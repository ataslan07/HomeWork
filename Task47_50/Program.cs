// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int m = 3;
int n = 4; 
double [,] array = new double [m,n];
Random rand = new Random();
for(int i = 0; i < m; i++ ) // array.GetLenght(0)
{
    // Console.WriteLine("i= "+i);
    for(int j = 0; j < n; j++)
    {
        array[i,j] = Math.Round(rand.NextDouble(),2)+rand.Next(-10,10); //NextDouble next - генерирует случайное число, double говорит о том, что число дробное
        // Math.Round(rand.NextDouble(),2) - сокращает до 2 знаков полсе запятой
        // Console.WriteLine("j="+j);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

int m = 4;
int n = 3; 
int [,] array = new int [m,n];
Random rand = new Random();
for(int i = 0; i < m; i++ ) // array.GetLenght(0)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = rand.Next(-10,10); 
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
int i1 = 3;
int j1 = 2;

if (i1 < m && i1>=0)
{
    Console.WriteLine("Correct index");
    if (j1 < n && j1>=0)
    {
        Console.WriteLine(array[i1,j1]);
    }
    else
    {
        Console.WriteLine("Incorrect index j");
    }
}
else
{
        Console.WriteLine("Incorrect index i");
}
