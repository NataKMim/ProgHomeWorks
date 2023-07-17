// Напишите программу, которая принимает на вход птяизначное число и проверяет, является ли оно палиндромом
int num = 0;
bool errFlag;

/*
do
{
    errFlag = false;
    Console.Write("Введите пятизначное целое число: ");
    var input = Console.ReadLine();
    if (!int.TryParse (input, out num)) 
    {
        Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
        errFlag = true;
    }
    else if ((Math.Abs(num)< 10000) || (Math.Abs(num) > 99999))  //по модулю для отрицательных чисел
            {
                Console.WriteLine("ОШИБКА! Вы ввели не пятизначное число!");
                errFlag = true;
            }

} while (errFlag);

Console.Write ("Число " + num);
// вариант 1
if ((num%10 == (num/10000))&&((num/10)%10 == (num/1000)%10))
    Console.WriteLine (" является палиндромом");
else 
    Console.WriteLine (" не является палиндромом");

// вариант 2
int []num_arr = new int [5];
for (int i = 0; i < 5; i++)
{
    num_arr[i] = num%10;
    num /= 10;
}

if ((num_arr[0] == num_arr[4])&&(num_arr[1]==num_arr[3]))
    Console.WriteLine (" является палиндромом");
else 
    Console.WriteLine (" не является палиндромом");



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1, y1, z1, x2, y2, z2;
Console.WriteLine("Введите координаты первой точки:");
Console.Write ("X1 = ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y1 = ");
y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Z1 = ");
z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write ("X2 = ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y2 = ");
y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Z2 = ");
z2 = Convert.ToInt32(Console.ReadLine());

double len;
//вариант 1
len = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
len = Math.Round(len, 2);
Console.WriteLine ("Расстояние между точками " + len);

//вариант 2
len = Math.Pow((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 0.5);
len = Math.Round(len, 2);
Console.WriteLine ("Расстояние между точками " + len);

*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

do
{
    errFlag = false;
    Console.Write("Введите целое число: ");
    var input = Console.ReadLine();
    if (!int.TryParse (input, out num)) 
    {
        Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
        errFlag = true;
    }
} while (errFlag);
Console.WriteLine($"Кубы чисел от 1 до {num}");
for (int i = 1; i <=num; i++)
{
    Console.WriteLine (i + " -> " + Math.Pow(i, 3));
}