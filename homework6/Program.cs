
// Задача 41 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int[] CreatePersonalArray(int size)
{
    int[] array = new int[size];

    for(int i = 0, j = 1; i < size; i++, j ++)
    {
        Console.Write("Input the " + j + " number: ");
        int nums = Convert.ToInt32(Console.ReadLine());
        array[i] = nums;
    }
    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void PositiveNums(int[] array)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            j++;
        }
    }
    Console.WriteLine("The amount of numbers above 0 is: " + j);
}

Console.Write("Input the amount of elements: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatePersonalArray(a);
ShowArray(myArray);
PositiveNums(myArray);
*/

// Второй способ

/*
int PositiveNums(int a)
{
    int j = 0;
    for(int i = 0, k = 1; i < a; i++, k++)
    {
        Console.Write("Input the " + k + " number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
        {
            j++;
        }

    }
    return j;
}

Console.Write("Input the amount of numbers: ");
int amount = Convert.ToInt32(Console.ReadLine());
int res = PositiveNums(amount);
Console.WriteLine("The amount of positive numbers is: " + res);
*/

// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
void Parallels(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1)/(k1-k2);
    double y = k1 * x + b1;
    if(k1-k2 == 0)
    {
        Console.Write("Wrong numbers for k1 and k2, this is not a line");
    }
    
    Console.Write("The cross point between the lines is (" + x + ";  " + y + ")");
}

Console.Write("Input the b1 point: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the b2 point: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the k1 point: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the k2 point: ");
int c2 = Convert.ToInt32(Console.ReadLine());

Parallels(a1, a2, c1, c2);

*/