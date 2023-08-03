//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*
void ArrSortMin (int [,] arr, int row, int num_columns)
{
    int tmp;
    for (int n = num_columns - 1; n >= 0; n--)
    {
        for (int i = 0; i < n; i++)
        {
            if (arr[row, i] < arr[row, n]) 
            {
                tmp = arr[row, n];
                arr[row, n] = arr[row, i];
                arr[row, i] = tmp;
            }
        }
    }
}

 void PrintArray (int [,] arr)
 {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j  = 0; j < arr.GetLength(1); j++)
        {
            Console.Write (arr[i, j] + "\t");
        }
    Console.WriteLine ();
    }
 }

int rows = new Random().Next(4,15);
int columns = new Random().Next(4,15);

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

Console.WriteLine ("-------------------------------");
for (int i = 0; i < rows; i++)
{
    ArrSortMin(array, i, columns);
}

PrintArray(array);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int SumArrRow(int [,] arr, int row)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[row, i];
    }
    return sum;
}


int rows = new Random().Next(2,10);
int columns = new Random().Next(2,10);

int [,] array = new int [rows, columns];

int MinRowValue = SumArrRow(array, 0);
int IndexMinRow = 0;

for (int i = 0; i < rows; i++)
{
    for (int j  = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(0,100);
        Console.Write (array[i, j] + "\t");
    }

    int sum = SumArrRow(array, i);
    if (i == 0)
    {
        MinRowValue = SumArrRow(array, 0);
    }
    else if (MinRowValue > sum) 
    {
        MinRowValue = sum;
        IndexMinRow = i;
    }
    Console.WriteLine ($"Сумма = {sum}");
}

Console.WriteLine ("Минимальная сумма {0} {1} {2} строке", MinRowValue, IndexMinRow == 1? "во" :"в",IndexMinRow + 1);


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void FillArr (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(-10,11);
        }
    }
}

 void PrintArray (int [,] arr)
 {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j  = 0; j < arr.GetLength(1); j++)
        {
            Console.Write (arr[i, j] + "\t");
        }
    Console.WriteLine ();
    }
 }


int rows1 = new Random().Next(2,5);
int columns1 = new Random().Next(2,5);
int columns2 = new Random().Next(2,5);

int [,] array1 = new int [rows1, columns1];
int [,] array2 = new int [columns1, columns2];
int [,] prodArr = new int [rows1, columns2];

FillArr(array1);
FillArr(array2);

Console.WriteLine ("Первый массив");
PrintArray(array1);

Console.WriteLine ("Второй массив");
PrintArray(array2);

for (int i = 0; i < rows1; i++)
{
    for (int j  = 0; j < columns2; j++)
    {
        prodArr[i, j] = CalcElement(i, j);
    }

}

Console.WriteLine ("Произведение массивов");
PrintArray(prodArr);

int CalcElement(int rw, int cl)
{
    int var = 0;
    for (int i = 0; i < columns1; i++)
    {
        var += array1[rw, i] * array2 [i, cl];
    }
    return var;
}




//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int NewValue(int [,,] arr)
{
    int val = new Random().Next(0,100);
  
    int i = 0;
    int j = 0;
    int k = 0;
    
    while (i < arr.GetLength(2))
    {
        while (j < arr.GetLength(0))
        {
            while (k < arr.GetLength(1))
            {
                if (arr[j, k, i] == val)
                {
                    val = new Random().Next(0,100);
                    i = -1;
                    j = -1;
                    k = -1;
                }
                
                k++;
                if (j < 0) break;
            }
            j++;
            k = 0;
            if (i < 0) break;
        }
        j = 0;
        k = 0;
        i++;
    }
    
    return val;
}

int rows = new Random().Next(2,4);
int columns = new Random().Next(2,4);
int pages = new Random().Next(2,4);

int [,,] array = new int [rows, columns, pages];

for (int k = 0; k < pages; k++)
{
    for (int i  = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j, k] = NewValue(array);
            Console.Write( $"{array[i, j, k]}({i},{j},{k})\t" );
        }
        Console.WriteLine ();
    }

   Console.WriteLine ();
}

*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

// 4x4 не интересно, сделала заполнение случайного массива
int rows = new Random().Next(4,15);
int columns = new Random().Next(4,15);

int [,] array = new int [rows, columns];

int k = 1;
int num;
bool flag = false;
if (rows > columns) 
{
    num = columns/2;
    if (columns%2 != 0) flag = true;
}
else 
{
    num = rows/2;
    if (rows%2 != 0) flag = true;
}
for (int n = 0; n < num; n++)
{
    for (int i = n; i < columns - n - 1; i++)
    {
        array[n, i] = k;
        array[rows-1-n, columns - 1 - i] = k + (columns - 2*n - 1) + (rows - 2*n - 1);
        k++;
    }
    for (int i = n; i < rows - n - 1; i++)
    {
        array[i, columns - 1 - n] = k;
        array[rows - i - 1, n] = k + (columns - 2*n - 1) + (rows - 2*n - 1);
        k++;
    }
    k = k + (columns - 2*n - 1) + (rows - 2*n - 1);
}

if (flag) 
{
    for (int i = num; i < columns - num; i++)
    {
        array[num, i] = k;
        k++;
    }
    for (int i = num + 1; i < rows - num; i++)
    {
        array[i, columns - 1 - num] = k;
        k++;
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j  = 0; j < columns; j++)
    {
        Console.Write (array[i, j] + "\t");
    }
    Console.WriteLine ();
}
