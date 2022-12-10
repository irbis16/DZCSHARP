// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[9];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10) / 10.0;
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
    if (array[i] > max)
        max = array[i];
for (int i = 0; i < array.Length; i++)
    if (array[i] < min)
        min = array[i];
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.Write($"MAX - MIN {Math.Round(max - min, 2)}");
