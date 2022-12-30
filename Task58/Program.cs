// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}
Console.Clear();
int[,] FirstMatrix = new int[3, 3];
InputMatrix(FirstMatrix);
Console.WriteLine();

int[,] SecondMatrix = new int [3, 3];
InputMatrix(SecondMatrix);
Console.WriteLine();

int[,] ResultMatrix = new int [3, 3];
for (int i = 0; i < 3; i++)
{
  for (int j = 0; j < 3; j++)
  {
    ResultMatrix[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    Console.Write(ResultMatrix[i, j] + " ");
  }
  Console.WriteLine();
}