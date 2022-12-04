
/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
int a;
Console.WriteLine($"Введите трехзначное число:");
int.TryParse(Console.ReadLine()!, out a);

//короткий вариант
Console.WriteLine($"{(a / 10) % 10}");
//длинный вариант:
//int N = a / 10;
//Console.WriteLine($"{N % 10}");
//int N;
//N = a % 10;
//Console.WriteLine($"{N}");