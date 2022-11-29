//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = int.Parse(Console.ReadLine());
if (n > m)
    Console.WriteLine($"max: {n}, min: {m}");
else if (m > n)
    Console.WriteLine($"max: {m}, min: {n}");
else
    Console.WriteLine($"{n} = {m}");