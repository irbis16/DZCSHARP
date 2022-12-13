/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int ie, je;
Console.Write($"Введите строку массива: ");
int.TryParse(Console.ReadLine(), out ie);
Console.Write($"Введите  столбец массива: ");
int.TryParse(Console.ReadLine(), out je);

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write("{0,3}", $" {array[i, j]}");
    }
    Console.WriteLine();//переход на новую строку
}
if (ie > array.GetLength(0) || je > array.GetLength(1) || ie < 1 || je < 1)
    Console.Write($"Значение вне массива");
else
{
    Console.Write($"Ваше число: {array[ie - 1, je - 1]}");
}