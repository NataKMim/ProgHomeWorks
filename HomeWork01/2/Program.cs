int num1;
int num2;
int num3;
num1 = new Random().Next(1,10);
num2 = new Random().Next(1,10);
num3 = new Random().Next(1,10);
Console.WriteLine($"Из чисел: {num1}, {num2}, {num3}");

//Console.Write("Введите первое число: ");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное число: ");
if (num1 > num2) 
    if (num1 > num3)
        Console.WriteLine(num1);
    else 
        Console.WriteLine(num3);
else 
    if (num2 > num3)
        Console.WriteLine(num2);
    else 
        Console.WriteLine(num3);