/*Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается*/
string finish="exit";

int i=0;
for ( ; ;)
{
    i++;
    Console.WriteLine(i);
    Console.WriteLine("Введите exit, чтобы закончить программу");
    String input=Console.ReadLine();
    if (finish==input) break;


}
