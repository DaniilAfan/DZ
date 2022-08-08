/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine ("Введите первое число");
string input1 = Console.ReadLine ();
int a= Convert.ToInt32(input1);
Console.WriteLine ("Введите второе число");
string input2 = Console.ReadLine ();
int b= Convert.ToInt32(input2);
Console.WriteLine ("Введите третье число");
string input3 = Console.ReadLine ();
int c= Convert.ToInt32(input3);
int max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.WriteLine("Максимальное число равняется");
Console.WriteLine (max);

