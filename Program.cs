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

//Задача№2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (n1 < n2)
{
    max = n2;
}
if (n2 < n3)
{
    max = n3;
}
Console.Write("Maximal number is: " + max);