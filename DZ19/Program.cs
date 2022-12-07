/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int N;
Console.Write ($"Введите пятизначное число:");
int.TryParse(Console.ReadLine()!, out N);
    if (N.ToString()[0] == N.ToString()[4] && N.ToString()[1] == N.ToString()[3])
    Console.Write($"{N} - палиндром");
    else
    {
        Console.Write($"{N} не палиндром");
    }