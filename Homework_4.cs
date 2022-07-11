/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

double Exponentiate(int A, int B)
{
    double result= Math.Pow(A, B);
    return result;
}

Console.Write("Введите число А: ");
int numA=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число A возведенноё в степень B = " + Exponentiate(numA, numB));*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

//с помощью рекурсии
int numberSum(int number)
{
    if(number < 10)
    {
        return number;
    }
    int count=number % 10;
    int nextNumber=number / 10;
    return count + numberSum(nextNumber);
}

Console.WriteLine("Введите число: ");
int result=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма всех цифр числа - "+numberSum(result));*/

//с помощью цикла


/*int numberSum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int count=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма всех цифр числа - "+numberSum(count));*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] fillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
    return array;
}

int[] arr = new int[8];
fillArray(arr);

Console.WriteLine($"[{string.Join(", ", arr)}]");
