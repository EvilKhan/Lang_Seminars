// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void inputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  }
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
  Console.WriteLine();
  }
}
void RealeaseMatrix(int[,] matrix)
{
    int minStr = 0;
    int minSumStr = 0;
    int sumStr = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minStr += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumStr += matrix[i, j];
        if (sumStr < minStr)
        {
            minStr = sumStr;
            minSumStr = i;
        }
        sumStr = 0;
    }
    Console.Write($"{minSumStr + 1}`я строка");
}
Console.Clear();
int[,] matrix = new int[4,4];
inputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
RealeaseMatrix(matrix);