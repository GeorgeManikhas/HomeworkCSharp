//Прошу прощения, что выполнил не вовремя.
// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void Plndr(string number)
{
    if (number [0] == number [4] || number [1] == number [3])
    {
        Console.WriteLine("Your number " + number + " is a palindrome");   
    }
    else
    {
        Console.WriteLine("Your number " + number + " is not a palindrome");
    }
}

Console.Write("Input a 5 digit number: ");
string a = Convert.ToString(Console.ReadLine());
Plndr(a);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
void Dist(double xa, double xb, double xz, double ya, double yb, double yz)
{
    double x = xa - ya;
    double y = xb - yb;
    double z = xz - yz;
    double dst = Math.Sqrt(x*x + y*y + z*z);
    double distance = Math.Round(dst, 3);

    Console.WriteLine("Distance is " + distance);
}
Console.Write("Input the first X: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second X: ");
double s = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third X: ");
double d = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first Y: ");
double f = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second Y: ");
double g = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the thitd Y: ");
double h = Convert.ToInt32(Console.ReadLine());

Dist(a, s, d, f, g, h);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Trpl(int number)
{
    int num = 1;
    while (num <= number)
    {
        Console.Write(num*num*num + " ");
        num++;
    }
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Trpl(a);
*/