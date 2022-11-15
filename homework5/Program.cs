// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void EvenNums(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine("The number of even numbers is: " + count);
}

Console.Write("Input the amount of elements: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
EvenNums(myArray);
*/

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void SumOfOdds(int[] array)
{
    int count = 0;
    for(int i = 1; i <= array.Length; i+=2)
    {
        count = count + array[i];
    }
    Console.WriteLine("The sum of odd elements is " + count);
}

Console.Write("Input the amount of elements: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
SumOfOdds(myArray);
*/

// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void DiffMaxMin(double[] array)
{
    double count = 0;
    double max = 0;
    double min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    min = max;
    for(int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    count = max - min;
    
    Console.WriteLine("The difference between max and min is: " + count);
}


Console.Write("Input the amount of elements: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(a);
ShowArray(myArray);
DiffMaxMin(myArray);
*/