int num;
int i = 2;

//num = new Random().Next(1,10);
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Четные числа до {num}: ");
if (i > num) 
    Console.Write(" - ");
else
    while (i <= num)
    {
        Console.Write($"{i} ");
        i+=2;
    }