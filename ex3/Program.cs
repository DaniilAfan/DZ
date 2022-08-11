/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine ("Введите  число");
string input = Console.ReadLine ();
int a= Convert.ToInt32(input);
if (a%2==0)
{
Console. WriteLine( "ваше число четное");
}
else
{
Console. WriteLine ( "ваше число нечетное");
}
