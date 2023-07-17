//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Введите первое число (А): ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (В): ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = " + PowAB());

double PowAB()
{
    return Math.Pow(A, B);
}

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Сумма всех цифр числа " + num + " равна " + SumNumbers(num));

int SumNumbers(int n)
{
    int sum = 0;
    if (n < 0) n *= -1;
    while (n > 0)
    {
        sum += n%10;
        n /= 10;
    }
    return sum;
}

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int []arr = new int [8];
FillArr();

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
