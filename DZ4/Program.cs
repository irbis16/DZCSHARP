/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
int a, b, c;
Console.WriteLine($"Введите первое число:");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите второе число:");
int.TryParse(Console.ReadLine()!, out b);
Console.WriteLine($"Введите третье число:");
int.TryParse(Console.ReadLine()!, out c);
if (a == b && b == c)
{
    Console.WriteLine($"Все числа равны ");
}
else
{
    if (a == b)
    {Console.WriteLine($"Первое число равно второму {a} = {b} ");}
    else 
    {
        if (a == c)
        {Console.WriteLine($"Первое число равно третьему {a} = {c} ");}   
        else 
        {
        if (b == c)
        {Console.WriteLine($"Второе число равно третьему {b} = {c} ");}   
        }
    }
}

if (a !=b && b !=c) {
if (a > b) 
{
if (a > c) {Console.WriteLine($"Первое число MAX {a}");}
}
else
{
if (a < c) 
{Console.WriteLine($"Третье число MAX {c}");}
 else
{Console.WriteLine($"Второе число MAX {b}");}
}
}

