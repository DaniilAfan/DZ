Console.WriteLine("введите номер дня недели (от 1 до 7)");
int number = Convert.ToInt32(Console.ReadLine());

if (number<1 && number>7)
{
 Console.WriteLine("Пожалуйста, введите числа от 1 до 7");
}
else 
{
    if (number==1)
    {
        Console.WriteLine("Понедельник, не выходной");
    }
    else if (number==2)
    {
        Console.WriteLine("Вторник, не выходной");
    }
    else if (number==3)
    {
        Console.WriteLine("Среда, не выходной");
    }
    else if (number==4)
    {
        Console.WriteLine("Четверг, не выходной");
    }
    else if (number==5)
    {
        Console.WriteLine("Пятница, почти выходной");
    }
    else if (number==6)
    {
        Console.WriteLine("Суббота, выходной");
    }
    else if (number==7)
    {
        Console.WriteLine("Воскресенье, выходной");
    }
    
}