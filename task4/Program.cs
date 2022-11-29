/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.Clear();
Console.Write("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int l = int.Parse(Console.ReadLine());
int max = n;
if (n > max)
    max = n;
else if (m > max)
    max = m;
else if (l > max)
    max = l;
Console.WriteLine($"{n}, {m}, {l} -> max: {max}");