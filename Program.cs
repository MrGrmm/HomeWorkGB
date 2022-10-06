//Семинар 1
/* Задача№1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (n1 > n2)
{
   max = n1;
   min = n2;
}
else
{
    max = n2;
    min = n1;
}
Console.WriteLine("max number = " + max);
Console.WriteLine("min number = " + min);

*/

/* Задача№2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (n2 > n1)
{
    max = n2;
}

if (n2 < n3)
{
    max = n3;
}

if (n1 > n3)
{
    max = n1;
}

Console.Write("Maximal number is: " + max);

*/

/* Задача№3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input first number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2==1)
{
    Console.WriteLine("This number is odd: " + num);
}
else
{
    Console.WriteLine("This number is even: " + num);
}

*/

/* Задача№4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Write a positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (n > 0)
{    
    while (i < n)
    {
        if (i % 2 == 0)
        {
            Console.Write(", " + i);
        } 
        i++;
    }
}
else
{
    Console.Write("!!!You entered a negative number!!!");
}

*/

//Семинар 2

/* Задача№1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigitOfThree(int num)
{   
    int sec;

    int ed = num / 10;
    sec = ed % 10;

    return sec; 
}

Console.WriteLine("Tape a three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 1000 == number && number / 100 != 0)
{
    int second = FindSecondDigitOfThree(number);
    Console.WriteLine($"A second digit is: " + second);
}
else
{
    Console.WriteLine("The number you entered is not three digits: " + number ); 
}

*/

//Задача №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Задача №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int FindAHoliday(int num)
{
  int weekend = 6 & 7;
 
  if (num == weekend)
  {
  Console.WriteLine("It's a holiday");
  }
  else
  Console.WriteLine("It's not a holiday");
  return weekend;
}
Console.Write("Enter a number from one to seven which will mean the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <=7)
    {
        int thrDig = FindAHoliday(number);
    }
else
{
    Console.WriteLine("Error: There are only seven days in a week!");
}

