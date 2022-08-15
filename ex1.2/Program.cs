/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/
Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1000 && number>99) 
{
int secondnumber =(number%100)%10;
Console.WriteLine( "вторая цифра числа"+" "+number+" "+"равняется"+" "+secondnumber);
}
else
{
    Console.WriteLine("пожалуйста введите трехзначное число");
}