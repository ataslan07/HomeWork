// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int pow (int A, int B) 
{
    int result = 1;
    for (int i = 1; i<=B; i++ ) //всегда 3 части - начальное значение для счетчика, условие, когда должно остановиться, третье - это шаг
        {
            result*=A;
        }
        return result;
}

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

Console.Write($"Результат: {pow(A,B)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int sum (int A)
{
    int b=0;
    while (A>0)
    {
        b+=A%10;
        A/=10;
    }
    return b;
} 

Console.Write("Enter the number: ");
int A = int.Parse(Console.ReadLine());

Console.Write(sum(A)); // когда вводим А не нужно указывать int 


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] Array()
{
    int[] arr = new int[8];
    Random r = new Random(); //создает рандомное число
    for(int i=0; i<8; i++)  //for всегда вне цикла, переменную i можно вводить внутри for
    {
        arr[i] = r.Next(-1000,1000);          //next - давет возможность генерировать числа
    }    
    return arr;
}
int[]final=Array();
for(int i=0; i<8; i++)
{
    Console.Write($"{final[i]}, ");
}