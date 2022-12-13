// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Console.WriteLine("Введите элементы массива через пробел");
Console.Write("введите числа массива через пробел:\n");
string[] numbers = Console.ReadLine()!.Split(' ');
int[] array = new int[numbers.Length];
Console.Write($"Ваш массив:\n");
for (int i = 0; i < numbers.Length; i++)
{
    int.TryParse(numbers[i], out array[i]);
    Console.Write($"{array[i]} ");
}

int k = 0;
foreach (var i in array)
    if (i > 0)
        k++;
Console.Write($"\n{k} число больше 0");

