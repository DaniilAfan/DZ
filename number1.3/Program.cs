/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int a1= num/10000;
int a2= (num-a1*10000)/1000;
int a5= num%10;
int a4= (num)/10%10;
if (a1==a5 && a2==a4)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}