// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillRandomNumbers(int[] arr, int from, int to)
{
 Random rand = new Random();

 for (int i = 0; i < arr.Length; i++)
 {
  arr[i] = rand.Next(from, to);
 }
}

void PrintNums(int[] arr)
{
 foreach (int el in arr)
 {
  Console.Write(el + " ");
 }
 Console.WriteLine();
}

int even(int[] arr, int from, int to)
{
 int count = 0;

 foreach (int val in arr)
 {
  if (val % 2==0)
  {
   count++;
  }
 }

 return count;
}

int[] arr = new int[5];

FillRandomNumbers(arr, 0, 1000);
PrintNums(arr);

int from = 0, to = 1000;
int EvenNumber = even(arr, from, to);

Console.WriteLine($" {EvenNumber}  even numbers");