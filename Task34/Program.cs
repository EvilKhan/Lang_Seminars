// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void InputArray (int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}
void ReleaseArray (int[] array)
{
  int count = 0;
  for (int j = 0; j < array.Length; j++)
  {
    if (array[j]%2==0)
    count++;
  }
  Console.WriteLine($"[{string.Join(", ", array)}]");
  Console.WriteLine($"Четных чисел: {count}.");
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
ReleaseArray(array);