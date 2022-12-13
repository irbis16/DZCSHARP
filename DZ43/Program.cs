/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double b1, k1, b2, k2, x, y;
Console.Write($"введите b1: \n");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write($"введите k1: \n");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write($"введите b2: \n");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write($"введите k2: \n");
double.TryParse(Console.ReadLine()!, out k2);

//k1 * x + b1= k2 * x + b2
//k1 * x - k2 * x =  b2 - b1
//y = k2 * x + b2
//y = k1 * x + b1, y = k2 * x + b2
if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.Write($"прямые пересекаются в точке ({x};{y})");
}
else
{
    Console.Write($"прямые не пересекутся");
}

