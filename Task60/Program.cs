// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] D3Matrix(int str, int col, int depth)
{
  int count = 10;
  int[,,] matrix = new int[str, col, depth];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        matrix[i, j, k] = count;//точно не повторятся
        count++;
      }
    }
  }
  return matrix;
}
void printMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write($"({i}),({j}),({k}) - {matrix[i,j,k]} \t");
      }
      Console.WriteLine();
    }
    
  }
  
}
Console.Clear();
Console.Write("Введите размеры 3D матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size[0]*size[1]*size[2]<90)
{
  int[,,] D3Matr = D3Matrix(size[0], size[1], size[2]);
  printMatrix(D3Matr);
}
else
  Console.WriteLine("ERROR");