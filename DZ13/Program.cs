﻿/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
int N;
Console.Write ($"Введите число:");
int.TryParse(Console.ReadLine()!, out N);
    if (N > 999)
    Console.Write($"{N.ToString()[2]}");
// Подсмотрел в интернете  N.ToString()[2]
    else
    {
    Console.Write($"третьей цифры нет");
    }




