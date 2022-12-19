// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("введите массив, через пробел:");
int[] n = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < n.Length; i++)
{
  if (n[i] >= 0)
  {
    count++;
  }
}
Console.WriteLine($"[{string.Join(" ,", n)}] - чисел больше 0: {count}");