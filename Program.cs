﻿//Семинар 1
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

/*Задача №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Find3thDigit(int num)
{
    int third;
    while (num > 999)
        num = num / 10;
        third = num % 10;
    return third;   
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}

if (number > 99)
{
    int thrDig = Find3thDigit(number);
    Console.WriteLine("The 3th digit is " + thrDig);
}
else
{
    Console.WriteLine("Error: The entered number is missing the third number.");
}
*/

/* Задача №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

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
*/

//Семинар 3 

/*Задача№1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int FindPolindrom(int num)
{
    if (num / 10000 != num % 10)
    {
        Console.WriteLine("Your number is not a polyndrom");
        return num;
    }
    num = num / 10; 
    num = num % 1000;
      
    if (num / 100 != num % 10)
    {
        Console.WriteLine("Your number is not a polyndrom");
        return num;
    }
    Console.WriteLine("Your number is a polyndrom");
    return num;
}
Console.WriteLine("Enter a five-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if (number == number % 100000)
{
    int pol = FindPolindrom(number);
}
else
{
    Console.WriteLine($"Error: The entered number '{number}' is not five digits");
}

*/

/*Задача№2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Range(double xa, double ya, double za, double xb, double yb, double zb)
{
    
    return Math.Round(Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2)),2);
}
Console.Write("Input xa-coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Inout ya-coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input za-coordinate: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Inout xb-coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Inout yb-coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Inout zb-coordinate: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Range(xa, ya, za, xb, yb, zb));

*/

/*Задача№3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableOfCubes(int num)
{
int count = 1;
while(count <= num)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
}
Console.WriteLine("input N number: ");
int number = Convert.ToInt32(Console.ReadLine());
TableOfCubes(number);

*/

//Семинар 4

//Задача№1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Задача№2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//Задача№3 Напишите программу, которая задаёт массив из m элементов и выводит их на экран.