using System.Runtime.ExceptionServices;

int a = 12;
int b = 5;
int sum = a + b;
int diff = a - b;
float div = (float)a / b;
int prod = a *  b;
int mud = a %  b;
Console.Write("Введите имя:  ");
string name = Console.ReadLine();
Console.WriteLine("Приввет, " + name);
Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int  second  = int.Parse(Console.ReadLine());
Console.WriteLine( first + second);
