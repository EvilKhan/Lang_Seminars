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
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] FirstMatrix = new int[size[0], size[1]];
InputMatrix(FirstMatrix);
Console.WriteLine();

int[,] SecondMatrix = new int [size[0], size[1]];
InputMatrix(SecondMatrix);
Console.WriteLine();

int[,] ResultMatrix = new int [size[0], size[1]];
for (int i = 0; i < ResultMatrix.GetLength(0); i++)
{
  for (int j = 0; j < ResultMatrix.GetLength(1); j++)
  {
    ResultMatrix[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
    Console.Write(ResultMatrix[i, j] + " ");
  }
  Console.WriteLine();
}