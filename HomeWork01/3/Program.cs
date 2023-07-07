int num;

//num = new Random().Next(1,10);

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {num} ");

if (num%2 == 0) 
    Console.WriteLine("четное");
else 
    Console.WriteLine("нечетное");