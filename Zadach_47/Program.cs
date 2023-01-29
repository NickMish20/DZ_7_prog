/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
  
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();
double[,] GetArrayDouble(int m=3, int n=4, int min=0, int max=10, int toch=2)
  {
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
          {
            double drob=Math.Round(new Random().NextDouble(), toch);
            result[i, j] = new Random().Next(min, max + 1)+ drob;
          }
      }
return result;
}
  
void PrintArrayDouble(double[,] douArray)
  {
    for (int i = 0; i < douArray.GetLength(0); i++)
      {
        for (int j = 0; j < douArray.GetLength(1); j++)
          {
            Console.Write($"{douArray[i,j]:f2} ");
          }
        Console.WriteLine();
      }
  }

double[,] mass= GetArrayDouble();
PrintArrayDouble(mass); 