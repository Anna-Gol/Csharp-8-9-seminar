// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = GetArray();

Console.WriteLine($"Упорядоченный массив: ");
OrderedArray(array);
WriteArray(array);

int[,] GetArray()
{

    int[,] array = new int[new Random().Next(3, 6), new Random().Next(3, 6)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    return array;

}


void OrderedArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int minSum = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumLineElements(array, i);
  if (sumLine > tempSum)
  {
    sumLine = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"Строкa с наименьшей суммой ({sumLine}) элементов: {minSum + 1}");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] firstArr = GetArrays();
int[,] secondArr = GetArrays();
int[,] result = new int[2,2];

int[,] GetArrays()
{

    int[,] array = new int[new Random().Next(2, 3), new Random().Next(2, 3)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    return array;

}


Console.WriteLine($"Произведение матриц: ");
MultiplyArrays(firstArr, secondArr, result);


int[,] MultiplyArrays(int[,] firstArr, int[,] secondArr, int[,] result)
{
  for (int i = 0; i < 2; i++)
  {
    for (int j = 0; j < 2; j++)
    {
      int sum = 0;
      for (int k = 0; k < 2; k++)
      {
        sum += firstArr[i,k] * secondArr[k,j];
      }
      result[i,j] = sum;
      Console.Write(result[i,j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  Console.WriteLine();
  return result;
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array3D = new int[2, 2, 2];
CreateArray(array3D);
WriteArray3d(array3D);


void WriteArray3d (int[,,] array3D)
{
  for (int i = 0; i < 2; i++)
  {
    for (int j = 0; j < 2; j++)
    {
      for (int k = 0; k < 2; k++)
      {
        Console.Write( $"{array3D[i,j,k]} ({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[2 * 2 * 2];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < 2; x++)
  {
    for (int y = 0; y < 2; y++)
    {
      for (int z = 0; z < 2; z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] squareArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
  squareArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < n - 1)
    j++;
  else if (i < j && i + j >= n - 1)
    i++;
  else if (i >= j && i + j > n - 1)
    j--;
  else
    i--;
}

WriteArr(squareArray);

void WriteArr (int[,] arr)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      if (arr[i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}