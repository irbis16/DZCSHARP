/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int N;
int sum = 0;
Console.Write ($"Введите число от 1:");
int.TryParse(Console.ReadLine()!, out N);
for (int i = 0; i <= N; i++)
sum = sum + i;

Console.Write ($"{sum} ");