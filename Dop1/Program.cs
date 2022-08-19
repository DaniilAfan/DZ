/*В переменной string есть секретное сообщение, 
во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/
string message = "секретное сообщение";
int password = 1234;
int trail =0;
int accept=0;
while (trail<3 & accept <1 )
{
    Console.WriteLine("Пожалуйста введите пароль, чтобы получить сообщение");
    int input = Convert. ToInt32(Console.ReadLine());
    if (input==password)
    {
        Console.WriteLine(message);
        accept=1;
    }
    else
    {
        Console.WriteLine("Вы ввели неправильный пароль");
        trail++;
    }
}
if (trail==3)
{
    Console.WriteLine("Количество попыток превышено, повторите попытку позже");
}



