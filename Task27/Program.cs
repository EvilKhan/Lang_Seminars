// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int result = 0;
for (int i = 0; i < n.Length; i++)
{
  result = result + Convert.ToInt32(n[i].ToString());
}
Console.WriteLine(result);