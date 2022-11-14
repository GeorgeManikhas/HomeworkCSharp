// Задача 25 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
void Step(int number, int power)
{
    int i = 2;
    int res = number;
    int res1 = number;
    while(i <= power)
    {
        res = res * res1;
        i++;
    }
    Console.WriteLine("The answer is " + res);
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power: ");
int b = Convert.ToInt32(Console.ReadLine());
Step(a, b);
*/

// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void Sum(int number)
{
    int numl = Convert.ToString(number).Length;
    int numb = 0;
    int res = 0;

    for (int i = 0; i < numl; i++){
      numb = number - number % 10;
      res = res + (number - numb);
      number = number / 10;
    }
   Console.WriteLine("The sum of the digits in the number is " + res);
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Sum(a);
*/



// Пытался сделать задачу с массивом, но безуспешно, постараюсь приложить в следующей домашней работе к этому же файлу.