// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
// на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"Введите {i+1}-й элемент: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите число, для сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());
if (k < 0){
  k = -k;
  k %= n;
}
else {
  k %= n;
  k = n - k;
}
for (int i = k; i < n; i++)
{
  Console.Write($"{array[i]} ");
}
for (int i = 0; i < k; i++)
{
  Console.Write($"{array[i]} ");
}
// string[] s = Console.ReadLine().Split("а");
// for (int i = 0; i < s.Length; i++)
//     Console.WriteLine(s[i]);
//работа split

// int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// for (int i = 0; i < s.Length; i++)
//     Console.WriteLine(s[i] * 10);

// int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// foreach (int element in s)
//     Console.WriteLine(element * 2);

// int n = Convert.ToInt32(Console.ReadLine());
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int k = Convert.ToInt32(Console.ReadLine());
// int[] result = new int[numbers.Length];
// k %= n;
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         result[i] = numbers[numbers.Length - k + i];
//     for (int i = 0; i < numbers.Length - k; i++)
//         result[k + i] = numbers[i];
//     Console.WriteLine($"{string.Join(" ", result)}");
// }
// else
// {
//     k = k * (-1);
//     for (int i = 0; i < k; i++)
//         result[numbers.Length - k + i] = numbers[i];
//     for (int i = 0; i < numbers.Length - k; i++)
//         result[i] = numbers[k + i];
//     Console.WriteLine($"{string.Join(" ", result)}");
// }
