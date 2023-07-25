/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 

int numPositiv = 0;
int i = 0;

//Вариант 1
ConsoleKeyInfo cki;
int j;

Console.WriteLine ($"Введите целые числа. Для окончания нажмите Esc");

do 
{
    i++;
    j = -1;
    Console.Write($"{i} число: ");
    do
    {
        cki = Console.ReadKey(true);

        if ((cki.Key == ConsoleKey.OemMinus)&&(j < 0))
        {
            j++;
            Console.Write("-");
        }
        if (((cki.Key >= ConsoleKey.D0) && (cki.Key <= ConsoleKey.D9))) 
        {
            if (j == -1) 
            {
                numPositiv++;
                j++;
            }
            j++;
           
            Console.Write(cki.Key.ToString().Substring(1));
           
        }
        
    }while ((cki.Key != ConsoleKey.Escape) && !((cki.Key == ConsoleKey.Enter)&&(j>0)));
    Console.WriteLine("");
}while (cki.Key != ConsoleKey.Escape);
if (j <= 0) i--;

//Вариант 2
int num = 0;
bool errFlag, outFlag = false;

Console.WriteLine ($"Введите целые числа. Для окончания введите пустую строку");
do
{
    i++;

    do
    {
        errFlag = false;
        Console.Write($"{i} число': ");
        var input = Console.ReadLine();
        if (input == "") 
        {
            outFlag = true;
            num = 0;
            i--;
            break;
        }
        if (!int.TryParse (input, out num)) 
        {
            Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
            errFlag = true;
        }

    } while (errFlag);
     
    if (num > 0) numPositiv++;

}while (!outFlag);



Print (i, numPositiv);

void Print (int n, int num)
{
    if (num == 0)
        Console.WriteLine ($"Не введено ни одного положительного числа из {n}");
    else if (num == 1)
        Console.WriteLine ($"Введено 1 положительное число из {n}"); 
        else if (num < 5)
                Console.WriteLine ($"Введено {num} положительных числа из {n}");
            else
                Console.WriteLine ($"Введено {num} положительных чисел из {n}");
}
*/
/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double [,]arr_coeff = new double[2, 2];

for (int i = 0; i < 2; i++)
{
    Console.WriteLine ($"Ввеедит коэффициенты уравнения {i+1} прямой");
    
    Console.Write($"k{i+1} : ");
    arr_coeff[i, 0] = GetNum();

    Console.Write($"b{i+1} : ");
    arr_coeff[i, 1] = GetNum();

}

Console.WriteLine ($"Уравнение первой прямой: y = {arr_coeff[0, 0]} * x + {arr_coeff[0, 1]}");
Console.WriteLine ($"Уравнение второй прямой: y = {arr_coeff[1, 0]} * x + {arr_coeff[1, 1]}");
if (arr_coeff[0, 0] == arr_coeff[1, 0])
{
    if (arr_coeff[0, 1] == arr_coeff[1, 1]) Console.WriteLine ("Прямые совпадают");
    else Console.WriteLine ("Прямые параллельны и не пересекаются");
}
else
{
    double x = (arr_coeff[1, 1] - arr_coeff[0, 1])/(arr_coeff[0, 0] - arr_coeff[1, 0]);
    double y = arr_coeff[0, 0] * x + arr_coeff[0, 1];
    Console.WriteLine ("Точка пересечения прямых: (" + x + "; " + y +")");
}

double GetNum ()
{
    double num = 0;
    bool errFlag = false;

    do
    {
        errFlag = false;

        var input = Console.ReadLine();

        if (!double.TryParse (input, out num)) 
        {
            Console.WriteLine("ОШИБКА! Вы ввели не число!");
            errFlag = true;
        }

    } while (errFlag);
    
    return num;
}
