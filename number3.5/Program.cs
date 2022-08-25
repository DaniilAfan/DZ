/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.*/
int size= new Random().Next (1,10);
double[] numbers = new double[size];
Fillarraydouble(numbers);
double max = numbers[0];
double min = numbers[0];
void Fillarraydouble (double[] array )
{
    for (int i=0; array.Length>i; i++)
    {
    array[i]= new Random().Next(-1000,1000);
    Convert.ToDouble(array[i]);
    array[i]=array[i]/100;
    }
}
for (int i=0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    if (numbers[i]>max)
    {
        max=numbers[i];
    }
    else if (numbers[i]<min)
    {
        min=numbers[i];
    }
}
Console.WriteLine(max-min);