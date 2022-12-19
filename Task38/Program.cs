// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 100) + Math.Round(new Random().NextDouble(), 2);
  }
}
void ReleaseArray(double[] array)
{
  double min = array[0], max=array[0];
  for (int j = 0; j < array.Length; j++)
  {
    if (array[j] > max)
    {
      max = array[j];
    }
    else if (array[j] < min)
    {
      min = array[j];
    }
  }
  Console.WriteLine($"[{string.Join(" ,", array)}]");
  Console.WriteLine($"сумма минимального {min} и максимального {max} : {min + max}");
}
Console.Clear();
Console.Write("введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
ReleaseArray(array);