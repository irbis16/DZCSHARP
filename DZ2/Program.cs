/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
int a, b;
Console.WriteLine($"Введите первое число:");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите второе число:");
int.TryParse(Console.ReadLine()!, out b);
if (a = b)
{
Console.WriteLine($"Числа равны");}
else
    if (a > b)
    {Console.WriteLine($"Наибольшее число {a}");}
    else
    Console.WriteLine($"Наибольшее число {b}");

