// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)
void inputMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(-10, 10);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);
int[,] matrix = new int[m, n];
Console.WriteLine($"{m}, {n}");//отображает размер массива
inputMatrix(matrix);
Console.Write("Введите строку элемента: ");
int str = Convert.ToInt32(Console.ReadLine())-1; //строка
Console.Write("Введите столбец элемента: ");
int col = Convert.ToInt32(Console.ReadLine())-1; //стобец
if (str <= m && str >= 0 && col <=n && col >= 0)
{
  Console.WriteLine($"на позиции {str + 1}x{col + 1} находится число: {matrix[str, col]}");
}
else
Console.WriteLine("такой позиции в массиве нет");
