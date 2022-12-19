// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
// Console.WriteLine("Введите значения для уравнения пересечения 2х прямых: y = k1 * x + b1, y = k2 * x + b2");
// Console.Write("Введите b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());
// double x = Math.Round((b2 - b1)/(k1 - k2), 2);
// double y = Math.Round(k1 * x + b1, 2);
// Console.WriteLine($"координаты точки пересечения: {x} , {y} ");
//первый напросившийся вариант
Console.WriteLine("Введите значения для уравнения пересечения 2х прямых: y = k1 * x + b1, y = k2 * x + b2, в одну строку, через пробел");
double[] n = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
double x = Math.Round((n[2] - n[0])/(n[1] - n[3]), 2);
double y = Math.Round(n[1] * x + n[0], 2);
Console.WriteLine($"координаты точки пересечения: {x} , {y} ");
//второй вариант через строку.