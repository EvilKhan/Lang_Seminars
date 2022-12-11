// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите любое положительное целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x > 999)
      x /= 10;
if (x> 99 && x < 1000)
    Console.WriteLine($"третья цифра -> {x%10}");
else if (x >= 0 && x < 100)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine("Не соответствует условию");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 100)
//     Console.WriteLine("Третьей цифры нет");
// else
// {
//     while (n > 1000)
//         n /= 10;
//     Console.WriteLine(n % 10);
// }
