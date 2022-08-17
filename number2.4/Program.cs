/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.452 -> 11

82 -> 10

9012 -> 12*/
Console.WriteLine("Введите число");
int num= Convert.ToInt32(Console.ReadLine());
int sum=0;
while (num>0)
{
    int a= num%10;
    num= Delitlustdigit(num);
    sum=sum+a;
}
Console.WriteLine("Сумма цифр вашего числа равняется"+" "+sum);
int Delitlustdigit(int number)
{
    int result= (number-number%10)/10;
    return result;
}