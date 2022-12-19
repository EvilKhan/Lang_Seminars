// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-99, 100);
  }
}
void ReleaseArray(int[] array)
{
  int result = 0;
  for (int j = 1; j < array.Length; j = j + 2)
  {
    result = result + array[j];
  }
  Console.WriteLine($"массив:[{string.Join(" ,", array)}]");
  Console.WriteLine($"сумма чисел на нечетных позициях = {result}");
}
Console.Clear();
Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
ReleaseArray(array);