/* //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = 0;
bool errFlag;

do
{
    errFlag = false;
    Console.Write("Введите трехзначное целое число: ");
    var input = Console.ReadLine();
    if (!int.TryParse (input, out num)) 
    {
        Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
        errFlag = true;
    }
    else if ((Math.Abs(num)< 100) || (Math.Abs(num) > 999))  //по модулю для отрицательных чисел
            {
                Console.WriteLine("ОШИБКА! Вы ввели не трехзначное число!");
                errFlag = true;
            }

} while (errFlag);

Console.WriteLine($"Вторая цифра числа {num} это {(Math.Abs(num%100)/10)}"); //по модулю для отрицательных чисел
*/
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = 0;
bool errFlag;
var input = "";
do
{
    errFlag = false;
    Console.Write("Введите любое  целое число: ");
    input = Console.ReadLine();
    if (!int.TryParse (input, out num)) 
    {
        Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
        errFlag = true;
    }
} while (errFlag);

if (num/100 == 0)
    Console.WriteLine("В числе " + num + " третьей цифры нет");
else
{    
    Console.Write($"Третья цифра числа {num} это ");
    //вариант 1
    if (input[0] == '-') 
        Console.WriteLine(input[3]);
    else 
        Console.WriteLine(input[2]);
    //вариант 2
    if (num < 0) num *= -1;
    while (num > 999)
    {
        num /= 10;
    }
    Console.WriteLine(num%10);
}
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int num = 0;
bool errFlag;
do
{
    errFlag = false;
    Console.Write("Введите день недели (число от 1 до 7): ");
    var input = Console.ReadLine();
    if (!int.TryParse (input, out num)) 
    {
        Console.WriteLine("ОШИБКА! Вы ввели не целое число!");
        errFlag = true;
    }
    else if ((num < 1) || (num > 7))
            {
                Console.WriteLine("ОШИБКА! Вы ввели неверное число!");
                errFlag = true;
            }
} while (errFlag);

if (num < 6) 
    Console.WriteLine("День недели " + num + " не выходной");
else 
    Console.WriteLine("День недели " + num + " выходной");
*/