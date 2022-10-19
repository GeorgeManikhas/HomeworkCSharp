// Домашнее задание 
// Задача 2.
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньше


/*

Console.Write("Input the first number:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number:  ");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.Write(a + " is the biggest number and " + b + " is the smallest one");
}
else
{
    Console.Write(b + " is the biggest number and " + a + " is the smallest one");
}

*/


// Задача 4.
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.Write("Input the first number:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number:  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number:  ");
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    if(a>c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if(b>c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}


*/

// Задача 6.
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Input a number:  ");
int a = Convert.ToInt32(Console.ReadLine());


if(a % 2 == 0)
{
    Console.WriteLine("Sure!");
}
else
{
    Console.WriteLine("Nope!");
}

*/

// Задача 8.
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*


Console.Write("Input a number:  ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 1;

while(b<=a)
{
    if(b % 2 == 0)
    {
        Console.Write(b);
    }
    else
    {
        Console.Write(" ");
    }
    b++;
}

*/

// Второе, как кажется более простое решение задачи 8:

/*

Console.Write("Input a number:  ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 2;

while(b<=a)
{
    Console.Write(b + " ");
    b=b+2;
}

*/