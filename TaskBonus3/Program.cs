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