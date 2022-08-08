/* Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7;
a = 2; b = 10 -> max = 10;
a = -9; b = -3 -> max = -3;*/
string input1 = Console.ReadLine();
int a= Convert.ToInt32(input1);
string input2 = Console.ReadLine();
int b= Convert.ToInt32(input2);
if (a>b )
{
Console.WriteLine (a);
}
else
{
Console.WriteLine (b);
}
if (a==b)
{
Console.WriteLine ("Введите разные числа");
}