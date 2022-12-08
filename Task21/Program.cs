// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату первой точки x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2)); //sqrt - корень, Pow - степень
Console.WriteLine($"Длина отрезка {Math.Round(result, 2)}");  //Round - округление.
