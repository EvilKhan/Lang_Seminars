// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число 1: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число 2: ");
double y = Convert.ToDouble(Console.ReadLine());
double result = x;
if (y > 0)
{
  for (int i = 1; i < y; i++)
    {
      result *= x;
    }
    Console.WriteLine(result);
}
else if (y == 0){
      result = 1;
      Console.WriteLine(result);
}
else
{
  for (int i = 1; i < -1 * y; i++)  
  {
    result *= x;  
  }
Console.WriteLine(Math.Round(1 / result, 2));
}
