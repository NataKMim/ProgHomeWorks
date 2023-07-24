//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int arr_size = 8;
int []arr = new int [arr_size];
FillArr3();
Console.WriteLine("Количество четных чисел в массиве -> " + ColPositivNumbers());

void FillArr3()
{
    int len = arr.Length - 1;
    Console.WriteLine("Полученный массив");
    Console.Write ("[");
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100,1000);
        Console.Write (arr[i] + ", ");
    }
    arr[len] = new Random().Next(100,1000);
    Console.WriteLine(arr[len] + "]");
}

int ColPositivNumbers()
{
    int n = 0;
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        if ((arr[i]%10)%2 == 0) n++;
    }
    return n;
}

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int arr_size = 4;
int []arr = new int [arr_size];
FillArr();
Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях -> " + SumOddIndexNumbers());

void FillArr()
{
    int len = arr.Length - 1;
    Console.WriteLine("Полученный массив");
    Console.Write ("[");
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,100);
        Console.Write (arr[i] + ", ");
    }
    arr[len] = new Random().Next(0,100);
    Console.WriteLine(arr[len] + "]");
}

int SumOddIndexNumbers()
{
    int sum = 0;
    int len = arr.Length;
    
    for (int i = 1; i < len; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
int arr_size = 4;
double []arr = new double [arr_size];
FillArrDoubleNum();
Console.WriteLine("Разница между максимальным и минимальным элеметами массива = " + DiffMaxMinArrElements());

void FillArrDoubleNum()
{
    int len = arr.Length - 1;
    Console.WriteLine("Полученный массив");
    Console.Write ("[");
    for (int i = 0; i < len; i++)
    {
        arr[i] = RandomDoubleNum(0, 100);
        Console.Write (arr[i] + ", ");
    }
    arr[len] = RandomDoubleNum(0, 100);
    
    Console.WriteLine(arr[len] + "]");
}

double RandomDoubleNum (int Max, int Min)
{
    return Math.Round(Min + new Random().NextDouble() * (Max - Min), 2);
}

double DiffMaxMinArrElements()
{
    double max = arr[0];
    double min = arr[0];
    int len = arr.Length;
    
    for (int i = 1; i < len; i ++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}
