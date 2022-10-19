// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int NewNumber(int number)
{
    number = number / 10;
    number = number % 10;
    return number;
}

Console.Write("Input a three digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = NewNumber(a);

Console.WriteLine("Your updated number of " + a + " is " + result);

*/

// Задача 13. 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int number)
{
    
    while(number >= 1000)
    {
        number /= 10;
    }
    number = number % 10;
    return number;
}



Console.Write("Input your number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a<100)
{
     Console.WriteLine("You're number is too short, try another!");
}
else
{
    int ThrD = ThirdDigit(a);
    Console.WriteLine( ThrD + " is the 3rd digit of your number.");
}
*/

// Второе решение задачи 13. С помощью преобразования в текстовой массив.

/*

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

string arraynumber = Convert.ToString(number);

if (arraynumber.Length > 2)
{
    Console.WriteLine("The 3rd number is " + arraynumber[2]);
}
else 
{
    Console.WriteLine("You're number is too short, try another!");
}

*/

// Задача 15.
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int number)
{
    if(number>5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number from 1 to 7 and I'll tell you if you have to go to work: ");
int a = Convert.ToInt32(Console.ReadLine());
bool res = Weekend(a);
if(a > 7 || a < 1)
{
    Console.WriteLine("Mate, there's only 7 days a week!");
}
else
{
    if(a > 5)
    {
        Console.WriteLine("It's " + res + "! You can chill today!");
    }
    else
    {
        Console.WriteLine("That's " + res + "! Get yourself to work!");
    }
}


