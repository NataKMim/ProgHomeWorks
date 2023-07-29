//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int arr_rows = GetSizeNum ("Введите кол-во строк в массиве (m)");

int arr_columns = GetSizeNum ("Введите кол-во столбцов в массиве (n)");

double [,] arr = new double [arr_rows, arr_columns];

Console.WriteLine($"Полученный массив {arr_rows} x {arr_columns}");
Console.Write ("[");
for (int i = 0; i < arr_rows; i++)
{
    for(int j = 0; j < arr_columns; j++)
    {
        arr[i, j] = RandomDoubleNum(0, 100);
        
        if ((i == (arr_rows - 1)) && (j == (arr_columns - 1))) Console.WriteLine(arr[i, j] + "]");
        else Console.Write (arr[i, j] + ", ");
    }
    Console.WriteLine("");
}

int GetSizeNum(string message)
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
                Console.WriteLine("ОШИБКА! Недопустимая размерность массива!");
                errFlag = true;
            }
            else if (num > 100) 
                {
                    Console.WriteLine("ОШИБКА! Слишком большая размерность массива!");
                    errFlag = true;
                }

    } while (errFlag);

return num;
}

double RandomDoubleNum (int Max, int Min)
{
    return Math.Round(Min + new Random().NextDouble() * (Max - Min), 2);
}


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// объявление и заполнение массива в задаче 47

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

int arr_rows = new Random().Next(1,10);
int arr_columns = new Random().Next(1,10);

int [,] arr = new int [arr_rows, arr_columns];

Console.WriteLine("Полученный массив");

for (int i = 0; i < arr_rows; i++)
{
    for (int j  = 0; j < arr_columns; j++)
    {
        arr[i, j] = new Random().Next(0,100);
        Console.Write (arr[i, j] + "\t");
    }
    Console.WriteLine ();
}


do 
{
    Console.WriteLine("Задайте позиции элемента массива для вывода (начиная с 1)");

    int n = GetUIntNum ("Строка");
    int m = GetUIntNum ("Столбец");

    if ((n > arr_rows) || (m > arr_columns)) Console.WriteLine("Такого элемента нет в массиве");
    else Console.WriteLine($"Элемент массива [{n}, {m}] = {arr[n-1, m-1]}");

    Console.WriteLine("Для повтора введите любой символ");
    
} while (Console.ReadLine() != "");
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);

int [,] array = new int [rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j  = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(0,100);
        Console.Write (array[i, j] + "\t");
    }
    Console.WriteLine ();
}


for (int i = 0; i < columns; i++)
{
    double avrg = 0;
    for (int j  = 0; j < rows; j++)
    {
        avrg += array[j, i];
    }
    avrg = Math.Round (avrg/rows, 2);
    Console.Write (avrg + "\t");
}
