//Семинар 1
/* Задача№1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number 1: ");       //Отвечает за вывод текста в "" в консоль
int n1 = Convert.ToInt32(Console.ReadLine());      //Объявляет переменную типа int (целые числа) и конвертирует внесённый пользователем текст именно в данный тип данных 
Console.Write("Input number 2: ");    //Новая строка ввода
int n2 = Convert.Todouble32(Console.ReadLine());   //даёт введённое значение объявленной переменной
int max = 0;    //Новая переменная типа int - целые числа
int min = 0;    //Новая переменная типа int - целые числа

if (n1 > n2)    // if = если, происходит сравнение двух переменныъ
{
   max = n1;    // присваивание значения к переменной
   min = n2;    // присваивание значения к переменной
}
else     // else = в ином случае
{
    max = n2;   // присваивание значения к переменной
    min = n1;   // присваивание значения к переменной
}
Console.WriteLine("max number = " + max);   //Ввывод результатов в консоль + перенос строки
Console.WriteLine("min number = " + min);   //Ввывод результатов в консоль + перенос строки

*/

/* Задача№2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");  //Отвечает за запрос текста в "" в консоль
int n1 = Convert.ToInt32(Console.ReadLine());      //даёт введённое значение объявленной переменной
Console.Write("Input second number: "); //Отвечает за запрос текста в "" в консоль
int n2 = Convert.ToInt32(Console.ReadLine());         //даёт введённое значение объявленной переменной
Console.Write("Input the third number: ");  //Отвечает за запрос текста в "" в консоль
int n3 = Convert.ToInt32(Console.ReadLine());      //даёт введённое значение объявленной переменной
double max = n1;

if (n2 > n1)     // if = если, происходит сравнение двух переменных
{
    max = n2;   //Присваивание
}

if (n2 < n3)    // if = если, происходит сравнение двух переменных
{
    max = n3;   //Присваивание
}

if (n1 > n3)    // if = если, происходит сравнение двух переменных
{
    max = n1;   //Присваивание
}

Console.Write("Maximal number is: " + max);   //Вывод результата в консоль, где в "сам текст" + название переменной для вывода

*/

/* Задача№3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input first number: ");        //Отвечает за запрос текста в "" в консоль
int num = Convert.ToInt32(Console.ReadLine());    //Присваивает значенние текста что ввёл пользователь в переменную типа Double

if (num % 2==1)     //Такая форма используется чтобы узнать остаток от деления
{
    Console.WriteLine("This number is odd: " + num);  //вывод в консоли текста и переменной
}
else  //= если нет то
{
    Console.WriteLine("This number is even: " + num);//вывод в консоли текста и переменной
}

*/

/* Задача№4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Write a positive number: ");   //Вывод и ввод текста в консоль
int n = Convert.ToInt32(Console.ReadLine());  //Присваивание текста что будет  к переменной (до какого числа показывать чётные)
int i = 1;    //объявление новой переменной с значением 1 (с этого числа будут показыватся чётные)

if (n > 0)   //если результат верный то..
{    
    while (i <= n)  //запуск цикла, цикл действует до тех пор пока условие верное
    {
        if (i % 2 == 0)   //если остаток от деления 0 то..
        {
            Console.Write( i );  //ввод в консоль
            if(i == n)      //если индекс равен введённому числу то 
            {
                Console.Write(".");           //печатаем точку      
            }            
                else      //если нет то 
                {
                    Console.Write(", ");   //печатаем запятую
                }
            
        } 
        i++;   //увеличивается индекс для работы цикла
    }
}
else     // если результат неверный то.. 
{
    Console.Write("!!!You entered a negative number!!!");  //пишет в консоль 
}

*/

//Семинар 2

/* Задача№1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigitOfThree(int num) //Объявление функции(метода) первый int - это тип метода, потом название, потом в (данные что войдут в метод из вне)
{   
    int sec;     //обьявление переменной что потом вернётся из метода путём return

    int ed = num / 10;    //удаляет последнюю цифру числа
    sec = ed % 10;          //удаляет первую цифру числа

    return sec;     //возвращает значение в основную программу
}

Console.WriteLine("Tape a three-digit number ");   //запрос числа в консоли
int number = Convert.ToInt32(Console.ReadLine());     //присваивание к переменной
if (number % 1000 == number && number / 100 != 0)   //проверка что число действительно трёхначное
{
    int second = FindSecondDigitOfThree(number);     //вызов метода где отправляется число
    Console.WriteLine($"A second digit is: " + second);     //результат после метода
}
else
{
    Console.WriteLine("The number you entered is not three digits: " + number );    //вывод в консоль числа что ввёл пользователь + уведомление что оно не трёхзначное
}

*/

/*Задача №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Find3thDigit(int num)     //объявление метода
{
    int third;       //объявление переменной что хотим вернуть
    while (num > 999)   //запуск цикла что приведёт к тому что число станет трёхзначным
        num = num / 10;     //убирает последнюю цифру из числа
    third = num % 10;     //оставляет только третью цифру из трёхзначного числа
    return third;    //возвращаем результат
}
Console.Write("Enter a number: ");  //запрашиваем у пользователя данные
int number = Convert.ToInt32(Console.ReadLine());   //присваиваем к int переменной
if (number < 0)     //если число отрицательное то
{
    number = number * -1;   //сделаем его положительным
}

if (number > 99)    //если число больше 99 то
{
    int thrDig = Find3thDigit(number);  //запускаем метод что найдёт третью цифру числа
    Console.WriteLine("The 3th digit is " + thrDig);    //результат метода
}
else    //если число меньше 99
{
    Console.WriteLine("Error: The entered number is missing the third number.");    //Объявление о том что третей цифры в числе не существует
}
*/

/* Задача №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int FindAHoliday(int num)   //объявление функции
{
  int weekend = 6 & 7;   //объявление переменной что нужна на выход с значением выходных дней
 
  if (num == weekend)   //если число совпадает с выходными то
  {
  Console.WriteLine("It's a holiday");  //выдаём в консоли что это выходной
  }
  else  //если нет то
  Console.WriteLine("It's not a holiday");  //выдаём что это не выходной
  return weekend;   //возвращаем значение выходного дня
}
Console.Write("Enter a number from one to seven which will mean the day of the week: ");    //запрашиваем день недели
int number = Convert.ToInt32(Console.ReadLine());   //присваиваем к переменной 
if (number >= 1 & number <= 7)  //если номер может быть днём недели то
    {
        int thrDig = FindAHoliday(number);  //вызываем метод
    }
else    //если нет то
{
    Console.WriteLine("Error: There are only seven days in a week!");   //пишем что число не может быть днём недели
}
*/

//Семинар 3 

/*Задача№1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int FindPolindrom(int num)    //объявляем метод который будет проверять число(является ли оно полиндромом), на вход принимаем само число
{
    if (num / 10000 != num % 10)    //если первая цифра из пятизначного числа не равна последней цифре то
    {
        Console.WriteLine("Your number is not a polyndrom");    //объявляем в консоли что число не полиндром
        return num;     //и возвращаем само число
    }
    num = num / 10;     //если цифры равны то избавляемся от них, сначало от последней
    num = num % 1000;   //потом от первой
      
    if (num / 100 != num % 10)  ////если первая цифра из пятизначного числа не равна последней цифре то
    {
        Console.WriteLine("Your number is not a polyndrom");    //объявляем в консоли что число не полиндром
        return num;     ////и возвращаем само число
    }
    Console.WriteLine("Your number is a polyndrom");    //если они равны то объявляем в консоли что число является полиндромом
    return num;     //и возвращаем само число
}
Console.WriteLine("Enter a five-digit number");     //просим ввести пятизначное число
int number = Convert.ToInt32(Console.ReadLine());   //присваиваем к переменной
if (number == number % 100000)      //проверяем пятизначное ли число
{
    int pol = FindPolindrom(number);    //если да то вызываем метод
}
else
{
    Console.WriteLine($"Error: The entered number '{number}' is not five digits");  //если нет то выдаём в консоли ошибку
}

*/

/*Задача№2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Range(double xa, double ya, double za, double xb, double yb, double zb)  //метод что будет считать растояние между двумя точками что берёт на вход
{
    
    return Math.Round(Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2)),2);  //математическая формула что высчитывает растояние между точками в 3д пространстве, также округление до сотых после запятой
}
Console.Write("Input xa-coordinate: ");     //запрос координат
double xa = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.Write("Inout ya-coordinate: ");     //запрос координат
double ya = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.Write("Input za-coordinate: ");     //запрос координат
double za = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.Write("Inout xb-coordinate: ");     //запрос координат  
double xb = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.Write("Inout yb-coordinate: ");     //запрос координат
double yb = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.Write("Inout zb-coordinate: ");     //запрос координат
double zb = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной

Console.WriteLine(Range(xa, ya, za, xb, yb, zb));       //Вызов метода с отправкой туда координат что ввёл пользователь

*/

/*Задача№3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableOfCubes(int num)   //объявление войд метода(ничего не возвращает) с числом на входе, что будет выдавать таблицу или перечень всех кубов от 1 до введёного числа
{
int aboveZero = 1;  //объявляем переменную откуда будем показывать кубы
Console.WriteLine("The cube table: ");  //переводим в следующую строку текст
while(aboveZero <= num) //запускаем цикл с условием - пока 1 больше или равен числу то
    {
        Console.WriteLine(Math.Pow(aboveZero,3));   //выводим в третью степень цифру
        aboveZero++;    //увеличиваем цифру на 1(++ = +1)
    }
}
Console.WriteLine("input N number: ");  //Запрашиваем число
int number = Convert.ToInt32(Console.ReadLine());   //присваиваем к переменной
TableOfCubes(number);   //вызываем метод

*/

//Семинар 4

/*Задача№1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowA_B(int a, int b)   //объявления метода что будет возводить первое принимаемое число в степень второго 
{
    int result = 1;  //создаём переменную для результата
    for(int i = 0; i < b; i++)    //запускаем цикл который будет возводить в степень путём умножения
        result = result * a;    //пишем уравнение что приведёт к результату
    return result;  //возвращаем результат
}
Console.WriteLine("Enter a natural number");    //запрашиваем первое число
int a1 = Convert.ToInt32(Console.ReadLine());   //присваиваем к переменной
Console.WriteLine("Enter the power to which you want to raise the entered number"); //запрашиваем число обозначающую в какую степень будем возводить
int b1 = Convert.ToInt32(Console.ReadLine());   //присваиваем к переменной
int num = PowA_B(a1, b1);   //запускаем метод
Console.WriteLine($"{a1} to the power of {b1} is {num}");   //выдаём резльтат после работы метода

*/

/*Задача№2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int num)    //объявление метода что принимает само числа на вход
{
    int sum = 0;    //создаём переменную для суммы
    while (num > 0)     //запускаем цикл с условием - пока число больше 0 то
    {
        sum += num % 10;    //сумма будет равна сумме + последняя цифра в числе
        num /= 10;  //убираем последнюю цифру в числе
    }
    return sum;     //возвращаем сумму всех цифр в числе
}
Console.WriteLine("Enter the number: ");    //запрашиваем число
int n = Convert.ToInt32(Console.ReadLine());    //присваиваем к переменной
Console.WriteLine($"Sum Of digits from a {n} is {SumOfDigits(n)}"); //выдаём результат метода с поясняющим текстом
*/

/*Задача№3 Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


int[] CreateArray(int size) //объявление метода что принимает на вхох размер массива что будет создаваться
{
    int[] array = new int[size];    //создание нового массива
    Console.WriteLine("Creating array: ");  //поясняющий текст в консоли
    for(int i = 0; i < size; i++)   //запуст цикла что будет запрашивать каждый эллемент у пользователя пока размер массива не станет размером что ввёл пользователь изначально
    {
        Console.WriteLine($"Enter the {i + 1} element of array: "); //поясняющий текст что запрашивает число у пользователя
        array[i] = Convert.ToInt32(Console.ReadLine()); //добавляет введённое числа в массив
    }
    Console.WriteLine("Complete!");     //поясняющий текст что массив заполнен
    return array;
}
void ShowArray(int[] array)     //объявление метода что покажет весь массив в консоли, принимает на вход сам массив
{
    for(int i = 0; i < array.Length; i++)   //создание цикла что будет проходится по массиву и печатать его
        if (i == array.Length - 1)  //если индекс равен размеру массива - 1(так как индекс считается с 0 и максимальный индекс всегда на 1 меньше размера массива) то 
            Console.Write(array[i] + ". ");     //печатаем точку после самого эллемента
        else    //если нет то
        Console.Write(array[i] + ", ");     //печатаем запятум после самого числа    
}

Console.Write("Input a number of elements: ");      //запрашиваем размер массива
int size = Convert.ToInt32(Console.ReadLine());     //присваиваем к переменной
int[] myArray = CreateArray(size);      //запрашиваем метод что создаёт массив
ShowArray(myArray);     //запрашиваем метод что распечатает массив
*/


//Семинар 5

/*Задача№1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void ShowArray(int[] array)     //объявление метода что покажет массив
{
    for(int i = 0; i < array.Length; i++)      //цикл для пробежки по каждому элементу массива
        Console.Write(array[i] + " ");      //Печатаем каждый элемент массива

    Console.WriteLine();  //переход на следующий ряд
}
int[] CreateRandomArray(int size, int minValue, int maxValue)   //объявление метода что создаст массив, принимает на вход размер массива и максимальные и минимальные значения эллементов
{
    int[] newArray = new int[size];     //создаст новый массив

    for(int i = 0; i < size; i++)   //цикл что пройдётся по каждому эллементу
        newArray[i] = new Random().Next(minValue, maxValue + 1);    //выдаст рандомные числа с условием максимального и минимального

    return newArray;    //вернёт готовый массив
}
int FindEvenNumbers(int[] array)    //объявляет метод что будет искать чётные числа, принимает на вход массив
{
    int aboveZero = 0;  // объявление переменной что будет считать количество чётных
    for(int i = 0; i < array.Length; i++)   //цикл что пройдёт по всем эллементам
        if (array[i] % 2 == 0)  //если эллемент массива является чётным, то если делится на 2 без остатка то
            aboveZero++;    //плюсуем 1 к количеству чётных
    return aboveZero;   //возвращаем количество чётных
}

Console.WriteLine("Enter the size of the array: ");     //запрашивает размер массива
int size = Convert.ToInt32(Console.ReadLine());     //присваивание размера массива к переменной
int[] myArray = CreateRandomArray(size, 100, 1000);     //вызов метода с отправкой туда условий: размер, минимальное число и максимальное число
ShowArray(myArray);     //вызов метода что покажет массив в консоль
int evens = FindEvenNumbers(myArray);       //вызов метода что покажет количество чётных
Console.WriteLine($"There are {evens} even numbers in this array");     //Печатаем результат в консоль
*/

/*Задача№2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void ShowArray(int[] array)  //объявление метода что покажет массив в консоли
{
    for(int i = 0; i < array.Length; i++)        //цикл что пройдётся по все эллементам массива
        Console.Write(array[i] + " ");      //распечатает каждый эллемент массива

    Console.WriteLine();        //переход на новую строку
}
int[] CreateRandomArray(int size, int minValue, int maxValue)       //объявление метода что создаст массив
{
    int[] newArray = new int[size];     //создаст массив

    for(int i = 0; i < size; i++)       //цикл что пройдёт по всем эллементом массива
        newArray[i] = new Random().Next(minValue, maxValue + 1);        //добавит рандомные числа в массив с условиями

    return newArray;    //вернёт массив
}
int SumOfOddPosition(int[] array)       //объявляет метод что посчитает сумму эллементов что находятся на нечётных позициях
{
    int sum = 0;        //создаём переменную для суммы
    for(int i = 1; i < array.Length; i += 2)        //цикл что пройдётся по нечётным позициям в массиве
        sum += array[i];        //будет прибавлять сумму
    return sum;     //вернуть сумму
}

Console.WriteLine("Enter the size of the array: ");     //запрос размера массива
int size = Convert.ToInt32(Console.ReadLine());         //присваивание к переменной
int[] myArray = CreateRandomArray(size, 0, 10);     //вызов метода что создаст массив
ShowArray(myArray);             //вызов метода что покажет массив
int res = SumOfOddPosition(myArray);        //вызов метода что выдаст сумму
Console.WriteLine($"Sum of odd position in array = {res}");     //печатаем результат с пояснением
*/

/*Задача№3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)    //объявление метода что создаст массив с вещественными числами
{
    double[] newArray = new double[size];       //создаёт массив вещественных чисел

    for(int i = 0; i < size; i++)       //цикл что создаст каждый эллемент в отдельности
      newArray[i] = Math.Round(new Random().Next(-999,1000) + new Random().NextDouble(), 5);        //создаст эллементы по очерёдности с условием случайных вещественных чисел  в интервале от -999 до 999
    
    return newArray;        //вернёт сам массив
}
void ShowArray(double[] array)      //объявление массива что покажет сам массив
{
    for(int i = 0; i < array.Length; i++)       //цикл что распечатает каждый эллемент
        Console.Write(array[i] + " ");      //распечатает каждый эллемент

    Console.WriteLine();        //переход к новой строке
}
double DifferenceBetwenMaxAndMinElements (double[] array)       //объявление функции что найдёт разницу между максимальным и минимальных эллементом в массиве
{
    double diff = 0;    //создаём переменную для разницы
    double max = array[0];      //обявляем переменную для максимального эллемента
    double min = array[0];      //обявляем переменную для минимального эллемента
    for(int i = 0; i < array.Length; i++)   //цикл что пройдёт по всем эллементам
    {
        if(array[i] > max)      //если эллемент под номинальным индексом больше чем эллемент что мы объявили максимальным то
            max = array[i];     //максимальным эллементом стоновится эллемент с номинальным индексом
        if(array[i] < min)      //если эллемент под номинальным индексом меньше чем эллемент что мы объявили минимальным то
            min = array[i];     //минимальным эллементом стоновится эллемент с номинальным индексом
    }
        diff = max - min;       //минусуем минимальный эллемент из максимального чтобы выяснить разницу
    return diff;        //возвращаем разницу
}

Console.WriteLine("Enter the size of the array: ");     //запрашиваем размер массива
int size = Convert.ToInt32(Console.ReadLine());     //даём переменную для размера массива
double[] myArray = CreateRandomArray(size);     //вызываем метод что создаст массив
ShowArray(myArray);     //распечатает массив
double res = Math.Round(DifferenceBetwenMaxAndMinElements(myArray), 5);     //вызовет метод  для поиска разницы и округляет сотые после запятой
Console.WriteLine("The differens betwen maximal and miniman elements in array is  " + res);     //распечатываем результат с пояснением
*/

//Семинар 6

//Задача№1 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*Решить без массива

void HowManyNumberThanZero (int size)       //объявление метода что будет считать сколько чисел больше нуля ввёл пользователь
{
    int aboveZero = 0;      //создаём переменную куда будет входить количество чисел больше 0
    int count = 0;      //создаём переменную для прохождения цикла
    while (count < size)    //цикл с условием: пока индекс меньше количества введённых чисел
    {
        Console.WriteLine("Enter your number: ");       //Запрос числа
        int num = Convert.ToInt32(Console.ReadLine());      //присваивание к переменной
        if (num > 0)    //если введённый номер больше нуля то
        {
            aboveZero++;       //+ в количество чисел
        }
        count++;    //двигаемся по циклу
    }
    Console.WriteLine($"You have entered {aboveZero} numbers greater than zero");   //распечатка результата с пояснением
}

Console.WriteLine("Enter amount of numbers: ");     //запрос количества эллементов
int size = Convert.ToInt32(Console.ReadLine());     //присваивание к переменной
HowManyNumberThanZero(size);        //вызов метода что посчитает количество чисел
*/

/*Задача№2 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindTheIntersection(double b1, double k1, double b2, double k2)    //объявление метода который найдёт точку пересечения двух прямых, принимает значения прямых на вход
{
    if (k1 == k2)     //если точки равны то
        Console.WriteLine("There is no point of intersection!!! The lines are parallel");   //пояснение что линии параллельны и точка пересечения отсутствует
    else    //если нет то
    {
        double x = Math.Round((b1 - b2) / (k2 - k1),3);     //решаем уравнение для поиска точки x
        double y = Math.Round(k2 * x + b2, 3);      //решашем уравнение для поиска точки y
        Console.WriteLine("Coordinates of the point of intersection of lines: ");   //пояснение что печатаем результат
        Console.WriteLine($"x:{x}; y:{y}");     //печатаем результат
    }
}
Console.WriteLine("Enter coordinates b1: ");    //запрос точки прямой
double b1 = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.WriteLine("Enter coordinates k1: ");    //запрос точки прямой
double k1 = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.WriteLine("Enter coordinates b2: ");    //запрос точки прямой
double b2 = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
Console.WriteLine("Enter coordinates k2: ");    //запрос точки прямой
double k2 = Convert.ToDouble(Console.ReadLine());   //присваивание к переменной
FindTheIntersection(b1, k1, b2, k2);    //вызов метода что найдёт точку пересечения
*/

//Семинар 7

/*Задача№1 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray()     //Объявляем метод что создаст двумерный массив, на вход не получаем ничего
{
    Console.Write("Input a number of rows: ");      //Запрашиваем количество строк
    int rows = Convert.ToInt32(Console.ReadLine());     //создаём переменную для строк
    Console.Write("Input a number of colums: ");    //Запрашиваем количество столбцов
    int columns = Convert.ToInt32(Console.ReadLine());      //создаём переменную для столбцов
    Console.Write("Input a min possible value: ");      //Запрашиваем минимальное значение эллементов
    int minValue = Convert.ToInt32(Console.ReadLine());     //Присваиваем к новой переменной
    Console.Write("Input a max possible value: ");      //Запрашиваем максимальное значение эллементов
    int maxValue = Convert.ToInt32(Console.ReadLine());     //Присваиваем к новой переменной

    double[,] array2d = new double[rows,columns];       //Создать новый двумерный массив с указанным количеством столбцов и строк
    
    for (int i = 0; i < rows; i++)      //цикл что пройдётся по строкам в массиве
    {
        for (int j = 0; j < columns; j++)      //цикл что пройдётся по столбцам
        {
            array2d[i,j] = Math.Round((new Random().Next(minValue, maxValue +1)) + new Random().NextDouble(), 2);   //Создаст каждый эллемент в по очереди, с условием пещественных чисел и минимальных и максимальных значений что выбрал пользователь
        }
    }
    return array2d;     //возвращаем готовый двумерный массив
}
void Show2dArray(double[,] array2d)     //объявляем функцию что распечатает массив в консоль, принимаем на вход сам массив
{
    for(int i = 0; i < array2d.GetLength(0); i++)       //цикл для прохождения по строкам
    {
        for(int j = 0; j < array2d.GetLength(1); j++)       //цикл что пройдётся по столбцам
            Console.Write(array2d[i,j] + " ");      //отделит эллементы друг от друга пробелом

        Console.WriteLine();    //перейдёт в новый ряд как закончатся эллементы в данной строке
    }
}
double[,] my2dArray = CreateRandom2dArray();        //вызов метода что создаст двумерный массив при помощи присваивания к переменной
Show2dArray(my2dArray);     //вызов метода что покажет массив, отправив туда сам массив
*/

/*Задача№2 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray()        //метод создаст двумерный массив
{
    Console.Write("Input a number of rows: ");  
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    

    int[,] array2d = new int[rows,columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2d[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2d;
}

void IndexSearch(int[,] array, int i, int j)    //объявление метода что примет на вход массив и позиции эллемента в двумерном массиве и выдаст сам эллемент
{

    if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))   //если существует такой индекс для строк и для столбцов то
        Console.WriteLine($"Element with indexes [{i},{j}] is: {array[i, j]}");     //показываем эллемент под данным индексом
    else    //если нет то
        Console.WriteLine("Element with this index does not exist in this array");  //пишем что такого эллемента нет
}


int[,] my2dArray = CreateRandom2dArray();   //вызываем метод что создаст массив
Console.Write("Input an index 'i' of element: ");   //запрашиваем индекс строки
int i = Convert.ToInt32(Console.ReadLine());        //присваиваем к переменной
Console.Write("Input an index 'j' of element: ");      //запрашиваем индекс столбца
int j = Convert.ToInt32(Console.ReadLine());        //присваиваем к переменной
IndexSearch(my2dArray, i, j);      //вызываем меток для поиски эллемента по индексу и отправляем туда массив и позицию эллемента
*/
/*Задача№3 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()    //создаст двумерный массив
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[rows,columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i,j] = new Random().Next(minValue, maxValue);
    
    return array2d;
}

void Show2dArray(int[,] array2d)    //покажет в консоли двумерный массив
{
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
            Console.Write(array2d[i,j] + " ");

        Console.WriteLine();
    }
}

void ShowArray(double[] array)      //покажет массив
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double[] Arifm(int[,] array2d)      //будет считать ср.арифм каждого столбца
{
    
    
    double[] arif = new double[array2d.GetLength(1)];   //создаст новый одномерный массив
    for (int j = 0; j < array2d.GetLength(1); j++)      //цикл что будет проходить по столбцам
    {
      
        int sum = 0;    //создаём переменную для результата
        for (int i = 0; i < array2d.GetLength(0); i++)      //будет проходить по строкам 
        {
            
            sum += array2d[i,j];        //посчитает сумму всех эллементов в столбце
            arif[j] = sum / array2d.GetLength(0);       //расчитает ср.ариф и отправит результат в наш массив
        }
    }

    return arif;    //возвращаем массив
}

int[,] my2dArray = CreateRandom2dArray();       //вызов метода что создаст двумерный массив
Show2dArray(my2dArray);     //вызов метода что покажет двумерный массив
Console.WriteLine();    //переход на новую строку
double[] arifmet = Arifm(my2dArray);    //вызов метода для поиска ср.арифм
ShowArray(arifmet);     //вызов метода что покажет одномерный массив с ср.арифм каждого столюца из двумерного массива
*/

//Семинар 8

/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[rows,columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array2d;
}

void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
            Console.Write(array2d[i,j] + " ");

        Console.WriteLine();
    }
}

void Sorted2DArray(int[,] array2d)
{       
    for(int i = 0; i < array2d.GetLength(0); i++)
        for(int j = 0; j < array2d.GetLength(1); j++)        
            for(int k = 0; k < array2d.GetLength(0) - j - 1; k++)
            {
                if (array2d[i,k] < array2d[i, k+1])
                {
                    int temp = array2d[i,k];
                    array2d[i,k] = array2d[i,k+1];
                    array2d[i,k+1] = temp;
                }
            }        
}

int[,] my2DArray = CreateRandom2dArray();
Show2dArray(my2DArray);
Sorted2DArray(my2DArray);
Console.WriteLine("Seichas budet proizvoditsa rabota po sortirovke po ubivaniiu kajdoi stroki");
Show2dArray(my2DArray);
*/

/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[rows,columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array2d;
}

void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
            Console.Write(array2d[i,j] + " ");

        Console.WriteLine();
    }
}

void ShowArray(int[] array)     //объявление метода что покажет весь массив в консоли, принимает на вход сам массив
{
    for(int i = 0; i < array.Length; i++)   //создание цикла что будет проходится по массиву и печатать его
        if (i == array.Length - 1)  //если индекс равен размеру массива - 1(так как индекс считается с 0 и максимальный индекс всегда на 1 меньше размера массива) то 
            Console.Write(array[i] + ". ");     //печатаем точку после самого эллемента
        else    //если нет то
        Console.Write(array[i] + ", ");     //печатаем запятум после самого числа    
}

void FindMinSumInRows(int[,] array2d)
{
    int[] sum = new int[array2d.GetLength(0)];            
    
    for(int i = 0, m = 0; i < array2d.GetLength(0); i++)
    {
        int summ = 0; 
        
        for(int j = 0; j < array2d.GetLength(1); j++)   
        
            summ += array2d[i,j];
            sum[m] = summ;            
            m++;    
                                       
    }
    int minSum = sum[0];
    int nMinSum = 0;
        for(int n = 0; n < sum.GetLength(0); n++)
        {
            if (sum[n] < minSum)   
            nMinSum = n;
            minSum = sum[n];
            
        }
        ShowArray(sum);
        Console.WriteLine();
        Console.WriteLine("stroka s naimenishei summoi allementov eto stroka pod indeksom:  " + nMinSum);
        
        
}   
int[,] my2dArray = CreateRandom2dArray();
Show2dArray(my2dArray);
FindMinSumInRows(my2dArray);
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array2d = new int[rows,columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array2d;
}

void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
            Console.Write(array2d[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] Matrix(int[,] array2dA, int[,] array2dB)
{
    int[,] array2dC = new int[array2dA.GetLength(0), array2dB.GetLength(1)];
        if (array2dA.GetLength(1) == array2dB.GetLength(0))
        {    
            for(int i = 0; i < array2dA.GetLength(0); i++)
                for(int j = 0; j < array2dA.GetLength(1); j++)
                    for(int k = 0; k < array2dB.GetLength(0); k++) 
                    {
                        array2dC[i,j] += array2dA[i,k] * array2dB[k,j];
                    }       
        }
        else
        {
            Console.WriteLine ("Error");
        }            

    return array2dC;
}

int[,] arrayA = CreateRandom2dArray();
int[,] arrayB = CreateRandom2dArray();
Show2dArray(arrayA);
Console.WriteLine();
Show2dArray(arrayB);
int[,] arrayC = Matrix(arrayA, arrayB);
Show2dArray(arrayC);


/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3DArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of volume: ");
    int volume = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] array3d = new int[rows,columns,volume];
    
    
   
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < volume; k++)
            
            array3d[i,j,k] = new Random().Next(minValue, maxValue + 1);

    return array3d;
}

void Show3dArray(int[,,] array3d)
{
    for(int i = 0; i < array3d.GetLength(0); i++)
        for(int j = 0; j < array3d.GetLength(1); j++)
            for(int k = 0; k < array3d.GetLength(2); k++)
                Console.Write($"{array3d[i,j,k]} ");
                    Console.WriteLine();
                    
}
int[,,] my3Darray = CreateRandom3DArray();
Show3dArray(my3Darray);
*/
//Напишите программу, которая заполнит спирально массив 4 на 4.
