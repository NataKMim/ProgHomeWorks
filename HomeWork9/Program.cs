
int GetUIntNum(string message)
{
    int num;
    bool errFlag;

    do
    {
        errFlag = false;
        Console.Write(message + ": ");
        var input = Console.ReadLine();
        if (!int.TryParse (input, out num)) 
        {
            Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
            errFlag = true;
        }
        else if (num <= 0)   //для отрицательных чисел
            {
                Console.WriteLine("ОШИБКА! Число меньше или равно нулю!");
                errFlag = true;
            }
    } while (errFlag);

    return num;
}

//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*

void PrintN (int n)
{
    if (n > 1) 
    {
        Console.Write (n + ", ");
        PrintN (n-1);
    }
    if (n == 1) Console.WriteLine (n);
}

int N = GetUIntNum("Введите значение N: ");
Console.WriteLine ($"Натуральные числа в промежутке от {N} до 1:");
PrintN(N);

*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int GetSum (int n, int m)
{
    if (n != m)
    {
        return n + GetSum (n+1, m);
    }
    else return n;
}

int N = GetUIntNum("Введите значение N: ");
int M = GetUIntNum("Введите значение M: ");

Console.Write ("Сумма натуральных элементов в промежутке {0} до {1} равна ", N<M? N:M, N<M? M:N);
if (N < M) Console.WriteLine (GetSum (N, M));
else Console.WriteLine (GetSum (M, N));
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0 )  return Akkerman (n - 1, 1);
    return Akkerman (n - 1, Akkerman (n, m - 1));
}

int M = GetUIntNum("Введите значение M: ");
int N = GetUIntNum("Введите значение N: ");

Console.Write ("A({0},{1}) = {2} ", M, N, Akkerman(M, N));