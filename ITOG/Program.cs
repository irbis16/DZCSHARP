// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] arrayS = { "Hello", "2", "world", ":-", "Ad" };
foreach (var item in arrayS)
{
    Console.Write($"{item} | ");
}
Console.Write($" --> ");
for (int i = 0; i < arrayS.Length; i++)
    //Console.Write($"\n{arrayS[i].Length}=> {arrayS[i]}\n");
    if (arrayS[i].Length < 4)
        Console.Write($" {arrayS[i]} | ");