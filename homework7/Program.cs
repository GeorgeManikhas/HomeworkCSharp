// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandomArray(int rows, int columns, int maxNumber, int minNumber)
{
    double[,] array = new double[rows, columns];
    double num = 0;
    for(int i = 0; i < rows; i++)
    {
       for(int j = 0; j < columns; j++)
       {
        num = new Random().Next(minNumber, maxNumber) + new Random().NextDouble(); 
        array[i, j] = Math.Round(num, 4);
       }
    }
    return array;
}

void ShowArray(double[,] array)
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

Console.Write("Input the amount of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the amount of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Max number: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(rows, columns, max, min);
ShowArray(myArray);

*/

// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] CreateRandomArray()
{
    
    int rows = new Random().Next(1, 10);
    int columns = new Random().Next(1, 10);
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
       for(int j = 0; j < columns; j++)
       {
        
        array[i, j] = new Random().Next(-100, 100);
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
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void CheckNumber(int[,] array, int numberA, int numberB)
{
    if(numberA > array.GetLength(0) || numberB > array.GetLength(1))
    {
        Console.WriteLine("There is no number with index: " + numberA + "; " + numberB);
    }
    else
    {
        Console.WriteLine(array[numberA, numberB] + " - that is your number with index: " + numberA + "; " + numberB);
    }
}


Console.Write("Input the first index: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second index: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray();
ShowArray(myArray);
CheckNumber(myArray, a, b);

*/


// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

/*
int [,] CreateNewArray(int rows, int columns)
{
    
    int [,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
            Console.Write(array[i, j] + " ");
            
        }
        Console.WriteLine();
    }
        
}

void Avg(int[,] array)
{
    double sum = 0;
    double avg = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        avg = Math.Round(sum/array.GetLength(0), 4);
        Console.WriteLine("The avg in the " + (j+1) + " row is: " + avg);
    }
}


Console.Write("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateNewArray(rows, columns);
ShowArray(myArray);
Avg(myArray);

*/