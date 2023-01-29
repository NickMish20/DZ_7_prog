/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

Console.Clear();
    
int NumInt (string mes= "Ведите целое число: ", string error = "Вы ввели некорректное значение!")   
  {
    Console.Write(mes);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))  
      {
        Console.WriteLine(error);
        Console.Write(mes);
      }
    return num;
  } 
    
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

void GetEllArrayP(int[,] arr, int ell= 1)
  {
    if (ell>arr.Length) {Console.Write("Элемента с порядковым номером  {0} в массиве не существует!",ell);}
    else
    {
      int[] mass = new int[arr.Length];
      int k=0;
      for (int i = 0; i < arr.GetLength(0); i++)
        {
          for (int j = 0; j < arr.GetLength(1); j++)
            {
              mass [k++] = arr[i, j];
            }      
        }
        Console.Write("Ваш элемент c порядковым номером {0}, это {1}", ell, mass[ell-1]);
     }
  }

void GetEllArrayI(int[,] arr, int m= 0, int n=0)
  {
    if (m>=arr.GetLength(0) || n>=arr.GetLength(1)) {Console.Write("Элемента с индексами  [{0},{1}] в массиве не существует!", m, n);}
    else
    {
       Console.Write("Ваш элемент  с индексами  [{0},{1}], это {2}", m, n, arr[m, n]);
     }
  }

string Choice (string mes= "Введите p если хотите узнать элемент по порядковому номеру в двумерном массиве или i, если хотите узнать значение элемента по 2 индексам двумерного массива: ", string error = "Вы ввели некорректное значение!")   
  {
    string mes1;
    while (true)  
      {
        Console.Write(mes);
        mes1=Console.ReadLine();
        if (mes1== "p" || mes1== "i") {break;}
        Console.WriteLine(error);
      }
    return mes1;
  }

int [,] mass = GetArrayInt();
PrintArrayInt(mass);
if (Choice()=="p") 
  {
    int num = NumInt("Введите номер искомого элемента: ");
    GetEllArrayP(mass, num);
  }
else 
  {
    int ind1= NumInt("Введите номер строки искомого элемента: "), ind2= NumInt("Введите номер столбца искомого элемента:");
    GetEllArrayI(mass, ind1, ind2);
  }