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