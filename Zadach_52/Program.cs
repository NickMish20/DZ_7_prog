/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();   
int[,] GetArrayInt(int m=3, int n=4, int min=0, int max=10)
  {
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
          {
            result[i, j] = new Random().Next(min, max + 1);
          }
      }
return result;
}

 void PrintArrayInt(int[,] inArray)
  {
    for (int i = 0; i < inArray.GetLength(0); i++)
      {
        for (int j = 0; j < inArray.GetLength(1); j++)
          {
            Console.Write($"{inArray[i,j]} ");
          }
        Console.WriteLine();
      }
  }
    
void ArithmeticMean(int [,] arr)
  {
    double m= arr.GetLength(0), n= arr.GetLength(1);
    
    Console.Write("Среднее арифметическое каждого столбца массива:");
    for (int j=0; j<n; j++)
      {
        double arith = 0;
        for (int i=0; i<m; i++)
            {
              arith += arr[i, j]/m;
            }
        Console.Write(" {0:f2}", arith);
      }
  }  

int [,] mass = GetArrayInt();
PrintArrayInt(mass);
ArithmeticMean(mass);
