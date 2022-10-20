//Семинар 1
/* Задача№1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number 1: ");
double n1 = Convert.Todouble32(Console.ReadLine());
Console.Write("Input number 2: ");
double n2 = Convert.Todouble32(Console.ReadLine());
double max = 0;
double min = 0;

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
double n1 = Convert.Todouble32(Console.ReadLine());
Console.Write("Input second number: ");
double n2 = Convert.Todouble32(Console.ReadLine());
Console.Write("Input the third number: ");
double n3 = Convert.Todouble32(Console.ReadLine());
double max = n1;

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
double num = Convert.Todouble32(Console.ReadLine());

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
double n = Convert.Todouble32(Console.ReadLine());
double i = 1;

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

double FindSecondDigitOfThree(double num)
{   
    double sec;

    double ed = num / 10;
    sec = ed % 10;

    return sec; 
}

Console.WriteLine("Tape a three-digit number ");
double number = Convert.Todouble32(Console.ReadLine());
if (number % 1000 == number && number / 100 != 0)
{
    double second = FindSecondDigitOfThree(number);
    Console.WriteLine($"A second digit is: " + second);
}
else
{
    Console.WriteLine("The number you entered is not three digits: " + number ); 
}

*/

/*Задача №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

double Find3thDigit(double num)
{
    double third;
    while (num > 999)
        num = num / 10;
        third = num % 10;
    return third;   
}
Console.Write("Enter a number: ");
double number = Convert.Todouble32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}

if (number > 99)
{
    double thrDig = Find3thDigit(number);
    Console.WriteLine("The 3th digit is " + thrDig);
}
else
{
    Console.WriteLine("Error: The entered number is missing the third number.");
}
*/

/* Задача №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

double FindAHoliday(double num)
{
  double weekend = 6 & 7;
 
  if (num == weekend)
  {
  Console.WriteLine("It's a holiday");
  }
  else
  Console.WriteLine("It's not a holiday");
  return weekend;
}
Console.Write("Enter a number from one to seven which will mean the day of the week: ");
double number = Convert.Todouble32(Console.ReadLine());
if (number >= 1 && number <=7)
    {
        double thrDig = FindAHoliday(number);
    }
else
{
    Console.WriteLine("Error: There are only seven days in a week!");
}
*/

//Семинар 3 

/*Задача№1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

double FindPolindrom(double num)
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
double number = Convert.Todouble32(Console.ReadLine());
if (number == number % 100000)
{
    double pol = FindPolindrom(number);
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

void TableOfCubes(double num)
{
double aboveZero = 1;
while(aboveZero <= num)
    {
        Console.WriteLine(Math.Pow(aboveZero,3));
        aboveZero++;
    }
}
Console.WriteLine("input N number: ");
double number = Convert.Todouble32(Console.ReadLine());
TableOfCubes(number);

*/

//Семинар 4

/*Задача№1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double PowA_B(double a, double b)
{
    double result = 1;
    for(double i = 0; i < b; i++)    
        result = result * a;    
    return result;
}
Console.WriteLine("Enter a natural number");
double a1 = Convert.Todouble32(Console.ReadLine());
Console.WriteLine("Enter the power to which you want to raise the entered number");
double b1 = Convert.Todouble32(Console.ReadLine());
double num = PowA_B(a1, b1);
Console.WriteLine($"{a1} to the power of {b1} is {num}");
*/


/*Задача№2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

double SumOfDigits(double num)
{
    double sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine("Enter the number: ");
double n = Convert.Todouble32(Console.ReadLine());
Console.WriteLine($"Sum Of digits from a {n} is {SumOfDigits(n)}");
*/     

/*Задача№3 Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


double[] CreateArray(double size)
{
    double[] array = new double[size];
    Console.WriteLine("Creating array: ");
    for(double i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter the {i + 1} element of array: ");
        array[i] = Convert.Todouble32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}
void ShowArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
            Console.Write(array[i] + ". ");
        else
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
double size = Convert.Todouble32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);

*/

//Семинар 5

/*Задача№1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void ShowArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
double[] CreateRandomArray(double size, double minValue, double maxValue)
{
    double[] newArray = new double[size];

    for(double i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
double FindEvenNumbers(double[] array)
{
    double aboveZero = 0;
    for(double i = 0; i < array.Length; i++) 
        if (array[i] % 2 == 0)
            aboveZero++; 
    return aboveZero;
}

Console.WriteLine("Enter the size of the array: ");
double size = Convert.Todouble32(Console.ReadLine());
double[] myArray = CreateRandomArray(size, 100, 1000);
ShowArray(myArray);
double evens = FindEvenNumbers(myArray);
Console.WriteLine($"There are {evens} even numbers in this array");
*/

/*Задача№2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void ShowArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
double[] CreateRandomArray(double size, double minValue, double maxValue)
{
    double[] newArray = new double[size];

    for(double i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
double SumOfOddPosition(double[] array)
{
    double sum = 0;
    for(double i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.WriteLine("Enter the size of the array: ");
double size = Convert.Todouble32(Console.ReadLine());
double[] myArray = CreateRandomArray(size, 0, 10);
ShowArray(myArray);
double res = SumOfOddPosition(myArray);
Console.WriteLine($"Sum of odd position in array = {res}");
*/

/*Задача№3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(double size)
{
    double[] newArray = new double[size];

    for(double i = 0; i < size; i++)
      newArray[i] = Math.Round(new Random().NextDouble(), 5);
    
    return newArray;
}
void ShowArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
double DifferenceBetwenMaxAndMinElements (double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for(double i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
    }
        diff = max - min;
    return diff;
}

Console.WriteLine("Enter the size of the array: ");
double size = Convert.Todouble32(Console.ReadLine());
double[] myArray = CreateRandomArray(size);
ShowArray(myArray);
double res = Math.Round(DifferenceBetwenMaxAndMinElements(myArray), 5);
Console.WriteLine("The differens betwen maximal and miniman elements in array is  " + res);
*/

//Семинар 6

//Задача№1 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*Решить без массива

void HowManyNumberThanZero (double size)
{
    double aboveZero = 0;
    double count = 0;
    while (count < size)
    {
        Console.WriteLine("Enter your number: ");
        double num = Convert.Todouble32(Console.ReadLine());
        if (num > 0)
        {
            aboveZero++;
        }
        count++;
    }
    Console.WriteLine($"You have entered {aboveZero} numbers greater than zero");
}

Console.WriteLine("Enter coordinates ");
double size = Convert.Todouble32(Console.ReadLine());
HowManyNumberThanZero(size);
*/

//Задача№2 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindTheIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые паралельны, точка пересечения отсутствует.");
    else
    {
        double x = Math.Round((b1 - b2) / (k2 - k1),3);
        double y = Math.Round(k2 * x + b2, 3);
        Console.WriteLine("Coordinates of the point of intersection of lines: ");
        Console.WriteLine($"x:{x}; y:{y}");
    }
}
Console.WriteLine("Enter coordinates b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinates k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinates b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinates k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
FindTheIntersection(b1, k1, b2, k2);





