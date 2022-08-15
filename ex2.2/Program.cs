/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i=0;
if (number<99)
{
    Console.WriteLine ("третьей цифры нет");
}
else
{
    while (number>1000 )
    {
        int del =number%10;
        number= (number-del)/10;
        i++;
    }
}
    if (i>0)
    {
    int thirdfigure=number%10;
Console. WriteLine(thirdfigure);  
    }


