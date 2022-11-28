// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
            
        }
    }
    return array;
}   

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FromMaxToMin(int[,] array)
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


Console.Write("Input the amount of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the amount of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(rows, columns, min, max);
Show2dArray(myArray);

Console.WriteLine();

FromMaxToMin(myArray);
Show2dArray(myArray);
*/

// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
            
        }
    }
    return array;
}   

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void MinSum(int[,] array)
{

    int minSumLine = 0;
    int sumLine = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
        {
        int tempSumLine = SumLine(array, i);
        if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        }
    Console.WriteLine((minSumLine+1) + " is a line with a lowest sum");
}



Console.Write("Input the amount of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the amount of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(rows, columns, min, max);
Show2dArray(myArray);
MinSum(myArray);
*/

// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] Create3dArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, depth];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < depth; k++)
            {
                array[i,j,k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}   

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + $" ({i},{j},{k}) ");
            } 
            Console.WriteLine();  
        }
        Console.WriteLine();
    }
}

Console.Write("Input the amount of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the amount of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the depth ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3dArray(rows, columns, depth, min, max);
Show3dArray(myArray);
*/

// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateSqArray(int a, int firstNum)
{
    int[,] array = new int[a, a];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < a; j++)
        {
            array[i,j] = firstNum;
            firstNum++;
            
        }
    }
    return array;
}   


void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
            {
                Console.Write($"0{array[i,j]} ");
            }
            else
            {
                Console.Write(array[i,j] + " ");
            }
        }
        Console.WriteLine();
    }
}

void Spiral(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while(temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
           j++; 
        }
        else
        {
            if (i < j && i + j >= array.GetLength(0) - 1)
            {
                i++;
            }
            else
            {
                if (i >= j && i + j > array.GetLength(1) - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
        } 
    }
}


Console.Write("Input the size of the array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first number in the array: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSqArray(a, firstNum);
ShowArray(myArray);
Console.WriteLine();
Spiral(myArray);
ShowArray(myArray);
